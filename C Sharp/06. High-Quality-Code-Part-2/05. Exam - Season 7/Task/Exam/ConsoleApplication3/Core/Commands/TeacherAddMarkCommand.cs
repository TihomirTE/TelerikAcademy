﻿using System.Collections.Generic;

namespace SchoolSystem.Core.Commands
{
    public class TeacherAddMarkCommand : ICommand
    {
        public string Execute(IList<string> parameters)
        {
            var teacherID = int.Parse(parameters[0]);
            var studentID = int.Parse(parameters[1]);
            var mark = float.Parse(parameters[2]);

            var student = Engine.Students[teacherID];
            var teacher = Engine.Teacher[studentID];

            teacher.AddMark(student, mark);

            return $"Teacher {teacher.FirstName} {teacher.LastName} added mark {mark} to student {student.FirstName} {student.LastName} in {teacher.Subject}.";
        }
    }
}
