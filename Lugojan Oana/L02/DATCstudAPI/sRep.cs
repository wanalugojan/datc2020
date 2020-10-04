using System.Collections.Generic;

namespace studentsAPI
{
    public static class sRep
    {
        private static List<Student> students = new List<Student>();

        public static void insert(Student data) {
            data.Id = students.Count;
            students.Add(data);
        }
        public static Student getById(int id) {
            return students.Find(student => student.Id == id);
        }
        public static List<Student> getAll() {
            return students;
        }
        public static void deleteById(int id) {
            students.RemoveAll(s => s.Id == id);
        }
        public static Student update(int id, Student student){
            int index = students.FindIndex(s => s.Id == id);
            students[index].prenume = student.prenume;
            students[index].nume = student.nume;
            students[index].fac = student.fac;
            students[index].an_stud = student.an_stud;
            return students[index];
        }
    }
}
