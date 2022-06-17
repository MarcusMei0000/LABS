using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class University
    {
        public string Name;
        public uint FirstYearStudentsAmount;
        public uint GraduatedStudentAmount;

        public University(string name, uint firstAmount, uint graduatedAmount)
        {
            Name = name;
            FirstYearStudentsAmount = firstAmount;
            GraduatedStudentAmount = graduatedAmount > firstAmount ? firstAmount : graduatedAmount;
        }

        public virtual double Q()
        {
            return (double)GraduatedStudentAmount / FirstYearStudentsAmount;
        }
        public virtual string GetQuality()
        {
            return $"Q: {Q()}\r\n";
        }
        public override string ToString()
        {
            return $"Название: {Name}\r\n" +
                    $"Количество зачисленных студентов: {FirstYearStudentsAmount}\r\n" +
                    $"Количество выпустившихся студентов: {GraduatedStudentAmount}\r\n" +
                    GetQuality(); 
        }
    }   

}
