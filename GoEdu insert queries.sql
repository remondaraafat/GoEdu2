--1--instructor
INSERT INTO Instructors (Name, Email, Age, Address, Phone, isDeleted, ImageUrl)
VALUES (N'أحمد حسن', 'ahmed@example.com', 35, N'القاهرة', '0123456789', 0, 'images/ahmed.jpg');

INSERT INTO Instructors (Name, Email, Age, Address, Phone, isDeleted, ImageUrl)
VALUES (N'منى علي', 'mona@example.com', 29, N'الإسكندرية', '0112345678', 0, 'images/mona.jpg');

INSERT INTO Instructors (Name, Email, Age, Address, Phone, isDeleted, ImageUrl)
VALUES (N'سعيد إبراهيم', 'saeed@example.com', 42, N'طنطا', '0109876543', 0, 'images/saeed.jpg');

INSERT INTO Instructors (Name, Email, Age, Address, Phone, isDeleted, ImageUrl)
VALUES (N'ليلى مصطفى', 'laila@example.com', 31, N'المنصورة', '0152233445', 0, 'images/laila.jpg');

INSERT INTO Instructors (Name, Email, Age, Address, Phone, isDeleted, ImageUrl)
VALUES (N'ياسر خالد', 'yasser@example.com', 38, N'أسيوط', '0129988776', 0, 'images/yasser.jpg');

--2--course
INSERT INTO Courses (Name, Price, Hours, MaxViews, Degree, MinDegree, Semester, StudentStage, CourseLevel, InstructorID, isDeleted, ImageUrl)
VALUES (N'الرياضيات للمرحلة الإعدادية', 300.0, 40, 5, 100.0, 50.0, 0, 0, 0, 1, 0, 'images/math1.jpg');

INSERT INTO Courses (Name, Price, Hours, MaxViews, Degree, MinDegree, Semester, StudentStage, CourseLevel, InstructorID, isDeleted, ImageUrl)
VALUES (N'الفيزياء للصف الثاني الثانوي', 450.0, 35, 4, 100.0, 60.0, 1, 1, 1, 2, 0, 'images/physics2.jpg');

INSERT INTO Courses (Name, Price, Hours, MaxViews, Degree, MinDegree, Semester, StudentStage, CourseLevel, InstructorID, isDeleted, ImageUrl)
VALUES (N'الكيمياء للصف الثالث الثانوي', 500.0, 50, 6, 100.0, 70.0, 1, 1, 2, 3, 0, 'images/chemistry3.jpg');

INSERT INTO Courses (Name, Price, Hours, MaxViews, Degree, MinDegree, Semester, StudentStage, CourseLevel, InstructorID, isDeleted, ImageUrl)
VALUES (N'اللغة الإنجليزية للمرحلة الإعدادية', 250.0, 30, 3, 100.0, 55.0, 0, 0, 1, 1, 0, 'images/english1.jpg');

INSERT INTO Courses (Name, Price, Hours, MaxViews, Degree, MinDegree, Semester, StudentStage, CourseLevel, InstructorID, isDeleted, ImageUrl)
VALUES (N'الأحياء للصف الأول الثانوي', 400.0, 38, 4, 100.0, 65.0, 0, 1, 0, 2, 0, 'images/biology1.jpg');

--3--student 
-- إدخال سجلات في جدول Student
INSERT INTO Students (Name, Email, Age, Address, StudentPhone, ParentPhone, isDeleted, ImageUrl)
VALUES (N'أحمد محمد', 'ahmed.mohamed@example.com', 22, N'الجيزة، مصر', '+201234567890', '+201234567890', 0, N'/images/Students1.jpg');

INSERT INTO Students (Name, Email, Age, Address, StudentPhone, ParentPhone, isDeleted, ImageUrl)
VALUES (N'فاطمة علي', 'fatima.ali@example.com', 24, N'القاهرة، مصر', '+201234567891', '+201234567891', 0, N'/images/student2.jpg');

INSERT INTO Students (Name, Email, Age, Address, StudentPhone, ParentPhone, isDeleted, ImageUrl)
VALUES (N'محمد خالد', 'mohamed.khaled@example.com', 20, N'الإسكندرية، مصر', '+201234567892', '+201234567892', 0, N'/images/student3.jpg');

INSERT INTO Students (Name, Email, Age, Address, StudentPhone, ParentPhone, isDeleted, ImageUrl)
VALUES (N'سارة يوسف', 'sara.yusuf@example.com', 23, N'المنصورة، مصر', '+201234567893', '+201234567893', 0, N'/images/student4.jpg');

INSERT INTO Students (Name, Email, Age, Address, StudentPhone, ParentPhone, isDeleted, ImageUrl)
VALUES (N'يوسف علي', 'youssef.ali@example.com', 21, N'طنطا، مصر', '+201234567894', '+201234567894', 0, N'/images/student5.jpg');

--4--Enroll
INSERT INTO Enrolls (StudentID, CourseID, InstructorID, Data, Status, isDeleted)
VALUES (1, 1, 1, '2024-09-01', N'مسجل', 0);

INSERT INTO Enrolls (StudentID, CourseID, InstructorID, Data, Status, isDeleted)
VALUES (2, 2, 2, '2024-09-03', N'قيد الانتظار', 0);

INSERT INTO Enrolls (StudentID, CourseID, InstructorID, Data, Status, isDeleted)
VALUES (3, 3, 3, '2024-09-05', N'تم الدفع', 0);

INSERT INTO Enrolls (StudentID, CourseID, InstructorID, Data, Status, isDeleted)
VALUES (4, 4, 1, '2024-09-07', N'مسجل', 0);

INSERT INTO Enrolls (StudentID, CourseID, InstructorID, Data, Status, isDeleted)
VALUES (5, 5, 2, '2024-09-09', N'مسجل', 0);

--5--lecture
INSERT INTO Lectures (Title, VideoURL, LectureTime, Description, isDeleted, CourseID)
VALUES (N'مقدمة في البرمجة', 'https://example.com/video1', '2024-09-01', N'محاضرة تعريفية عن المفاهيم الأساسية', 0, 1);

INSERT INTO Lectures (Title, VideoURL, LectureTime, Description, isDeleted, CourseID)
VALUES (N'التحكم في التدفق', 'https://example.com/video2', '2024-09-03', N'شرح if و switch بالتفصيل', 0, 1);

INSERT INTO Lectures (Title, VideoURL, LectureTime, Description, isDeleted, CourseID)
VALUES (N'الحلقات التكرارية', 'https://example.com/video3', '2024-09-05', N'توضيح الفروقات بين for و while', 0, 2);

INSERT INTO Lectures (Title, VideoURL, LectureTime, Description, isDeleted, CourseID)
VALUES (N'المصفوفات', 'https://example.com/video4', '2024-09-07', N'كيفية تعريف واستخدام المصفوفات', 0, 2);

INSERT INTO Lectures (Title, VideoURL, LectureTime, Description, isDeleted, CourseID)
VALUES (N'البرمجة الكائنية', 'https://example.com/video5', '2024-09-09', N'شرح OOP ومفاهيم الوراثة والتغليف', 0, 3);

--6--attend
INSERT INTO Attends (StudentID, LectureID, ViewsCount, isDeleted)
VALUES (1, 1, 5, 0);

INSERT INTO Attends (StudentID, LectureID, ViewsCount, isDeleted)
VALUES (2, 2, 10, 0);

INSERT INTO Attends (StudentID, LectureID, ViewsCount, isDeleted)
VALUES (3, 3, 3, 0);

INSERT INTO Attends (StudentID, LectureID, ViewsCount, isDeleted)
VALUES (4, 4, 8, 0);

INSERT INTO Attends (StudentID, LectureID, ViewsCount, isDeleted)
VALUES (5, 5, 12, 0);

--7--Question
-- إدخال سجلات في جدول Question
INSERT INTO Questions (Content, ModelAnswer, LectureId, isDeleted)
VALUES (N'ما هي عاصمة مصر؟', N'القاهرة', 1, 0);

INSERT INTO Questions (Content, ModelAnswer, LectureId, isDeleted)
VALUES (N'ما هو تعريف البرمجة؟', N'هي عملية كتابة التعليمات التي يفهمها الكمبيوتر لتنفيذها', 2, 0);

INSERT INTO Questions (Content, ModelAnswer, LectureId, isDeleted)
VALUES (N'ما هي أنواع البيانات في البرمجة؟', N'مثل النصوص والأرقام والـ Boolean', 3, 0);

INSERT INTO Questions (Content, ModelAnswer, LectureId, isDeleted)
VALUES (N'ماذا يعني مفهوم الـ OOP في البرمجة؟', N'البرمجة الكائنية التوجه', 4, 0);

INSERT INTO Questions (Content, ModelAnswer, LectureId, isDeleted)
VALUES (N'ما هو الفرق بين الـ SQL والـ NoSQL؟', N'SQL هو قاعدة بيانات علائقية، بينما NoSQL هو قاعدة بيانات غير علائقية', 5, 0);

--8--options
-- إدخال سجلات في جدول Option
INSERT INTO Options (Content, QuestionId, isDeleted)
VALUES (N'اختيار صحيح', 1, 0);

INSERT INTO Options (Content, QuestionId, isDeleted)
VALUES (N'اختيار خاطئ', 1, 0);

INSERT INTO Options (Content, QuestionId, isDeleted)
VALUES (N'اختيار صحيح', 2, 0);

INSERT INTO Options (Content, QuestionId, isDeleted)
VALUES (N'اختيار خاطئ', 2, 0);

INSERT INTO Options (Content, QuestionId, isDeleted)
VALUES (N'اختيار صحيح', 3, 0);

--9--comment
-- إدخال سجلات في جدول Comment
INSERT INTO Comments (LectureID, UserID, Content, Date, isDeleted)
VALUES (1, 1, N'تعليق ممتاز، الموضوع واضح جداً.', '2025-04-09 10:00:00', 0);

INSERT INTO Comments (LectureID, UserID, Content, Date, isDeleted)
VALUES (2, 2, N'هذه المحاضرة بحاجة إلى مزيد من التوضيح.', '2025-04-09 11:00:00', 0);

INSERT INTO Comments (LectureID, UserID, Content, Date, isDeleted)
VALUES (3, 3, N'أوافق على النقاط التي تم شرحها، كانت مفيدة.', '2025-04-09 12:00:00', 0);

INSERT INTO Comments (LectureID, UserID, Content, Date, isDeleted)
VALUES (4, 4, N'أتمنى أن يتم إضافة أمثلة أكثر في المحاضرات القادمة.', '2025-04-09 13:00:00', 0);

INSERT INTO Comments (LectureID, UserID, Content, Date, isDeleted)
VALUES (5, 5, N'أجد صعوبة في بعض المفاهيم، هل يمكن الشرح بشكل أوسع؟', '2025-04-09 14:00:00', 0);

--10--performance
-- إدخال سجلات في جدول StudentPerformance
INSERT INTO StudentPerformances (Grade, isDeleted, StudentId, LectureId)
VALUES (90, 0, 1, 1);

INSERT INTO StudentPerformances (Grade, isDeleted, StudentId, LectureId)
VALUES (85, 0, 2, 2);

INSERT INTO StudentPerformances (Grade, isDeleted, StudentId, LectureId)
VALUES (75, 0, 3, 3);

INSERT INTO StudentPerformances (Grade, isDeleted, StudentId, LectureId)
VALUES (80, 0, 4, 4);

INSERT INTO StudentPerformances (Grade, isDeleted, StudentId, LectureId)
VALUES (88, 0, 5, 5);

--11--answer
-- إدخال سجلات في جدول Answer
INSERT INTO Answers (StudentId, StudentAnswer, isDeleted, QuestionId)
VALUES (1, N'الإجابة الصحيحة هي أ', 0, 1);

INSERT INTO Answers (StudentId, StudentAnswer, isDeleted, QuestionId)
VALUES (2, N'الإجابة الصحيحة هي ب', 0, 2);

INSERT INTO Answers (StudentId, StudentAnswer, isDeleted, QuestionId)
VALUES (3, N'الإجابة الصحيحة هي ج', 0, 3);

INSERT INTO Answers (StudentId, StudentAnswer, isDeleted, QuestionId)
VALUES (4, N'الإجابة الصحيحة هي د', 0, 4);

INSERT INTO Answers (StudentId, StudentAnswer, isDeleted, QuestionId)
VALUES (5, N'الإجابة الصحيحة هي هـ', 0, 5);

--select
SELECT ID, Name FROM Students;