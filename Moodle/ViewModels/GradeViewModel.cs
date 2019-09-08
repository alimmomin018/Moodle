using Moodle.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Moodle.ViewModels
{
    public class GradeViewModel
    {
        private Grade _oldGrade;
        public ObservableCollection<Grade> _grade { get; set; }

        public GradeViewModel()
        {
            //constructor
            _grade = new ObservableCollection<Grade>
            {
                new Grade{ Subject = "2018F CIS 2103 3 [B123] Advanced Infrastructure Security", IsVisible = false},
                new Grade{ Subject = "2018F CSD 2354 3 [B123] Programming C# .NET", IsVisible = false},
                new Grade{ Subject = "2018F CSD 1134 5 [B122] Problem Solving/Program Logic", IsVisible = false},
                new Grade{ Subject = "2018F CSD 2206 5 [B226] Database Design & SQL", IsVisible = false},
                new Grade{ Subject = "2018F CSD 1113 5 [B123] Web Technologies I", IsVisible = false}
            };
        }

        public void ShoworHideSubject(Grade grade)
        {
            if(_oldGrade == grade)
            {
                grade.IsVisible = !grade.IsVisible;
                UpdateSubject(grade);
            }
            else
            {
                if (_oldGrade != null)
                {
                    _oldGrade.IsVisible = false;
                    UpdateSubject(grade);
                }
                grade.IsVisible = true;
                UpdateSubject(grade);
            }
            _oldGrade = grade;
        }

        private void UpdateSubject(Grade grade)
        {
            var index = _grade.IndexOf(grade);
            _grade.Remove(grade);
            _grade.Insert(index, grade);
        }
    }
}
