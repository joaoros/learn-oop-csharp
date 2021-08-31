namespace poo_s4___5 
{
    public class Aluno 
    {
        public string Name;
        public double FirstGrade, SecondGrade, ThirdGrade;

        public double FinalGrade() 
        {
            return FirstGrade + SecondGrade + ThirdGrade;
        }

        public bool IsApproved() 
        {
            if (FinalGrade() >= 60) 
            {
                return true;
            }
            else {
                return false;
            }
        }

        public double RemainingGrade() 
        {
            if (IsApproved()) 
            {
                return 0;
            }
            else 
            {
                return 60 - FinalGrade();
            }
        }
    }
}