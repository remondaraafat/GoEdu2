using GoEdu.Data;
using GoEdu.Models;
using GoEdu.ViewModel;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

namespace GoEdu.Hubs
{
    public class CommentHub : Hub
    {
        private readonly UnitOfWork unitOfWork;

        public CommentHub(UnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void AddComment(string lectureId, string content)
        {
            //add to database
            Comment comment = new Comment
            {
                Content = content,
                Date = DateTime.Now,
                LectureID = int.Parse(lectureId),
                UserID = 1 // identity
            };
            unitOfWork.CommentRepo.Insert(comment);
            unitOfWork.save();

            Student std = unitOfWork.StudentRepo.GetByID(1);
            VMComment newcomment = new VMComment
            {
                Content = content,
                Date = comment.Date,
                UserName = std.Name,
                UserImageUrl = std.ImageUrl,
                LectureId = comment.LectureID
            };
            //broadcast to all users
            Clients.All.SendAsync("CommentAdded", newcomment );//obj .net
        }
    }
}
