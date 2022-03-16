namespace VersionsCheck
{
    public class Version
    {
        /*string currentV = string.Empty;
        string otherV = string.Empty;

        public Version(string currentV, string otherV)
        {
            this.currentV = currentV;
            this.otherV = otherV;
        }*/

        public void CheckV(string currentV, string otherV)
        {
            string[] v1 = currentV.Split(('.'), (char)StringSplitOptions.RemoveEmptyEntries);
            string[] v2 = otherV.Split(('.'), (char)StringSplitOptions.RemoveEmptyEntries);

            foreach (string i in v1)
            {
                foreach (string j in v2)
                {   
                    if (v1.Count() == v2.Count())
                    {
                        int tmp1;
                        int tmp2;
                        tmp1 = Convert.ToInt32(i);
                        tmp2 = Convert.ToInt32(j);

                        if (tmp1 > tmp2)
                        {
                            Console.WriteLine("Needn't to update");
                        }
                        if (tmp1 < tmp2)
                        {
                            Console.WriteLine("Need to update");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input version in right format x.x.x");
                        Console.WriteLine();
                    }
                    
                }
            }
        }
    }
}