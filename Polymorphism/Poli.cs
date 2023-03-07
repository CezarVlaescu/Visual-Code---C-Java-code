using Polymorphism;

class Solution
{
    static void Main(string[] args)
    {
        // Polymorphism

        Teacher students = new Students();
        Teacher senior = new Senior();
        List <Teacher> interactiors = new List <Teacher>();

        interactiors.Add(students);
        interactiors.Add(senior);

        foreach(Teacher teacher in interactiors)
        {
            teacher.SeniorTalk();
            teacher.StudentsTalk();
        }

    }
}
