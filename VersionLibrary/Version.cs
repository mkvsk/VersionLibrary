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
            string[] v1 = currentV.Split('.');
            string[] v2 = otherV.Split('.');

            bool needToUpdate = false;

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
                            needToUpdate = false;
                        }
                        if (tmp1 < tmp2)
                        {
                            needToUpdate = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Input version in right format x.x.x");
                        Console.WriteLine();
                    }

                    if (needToUpdate)
                    {
                        Console.WriteLine("Need to update");
                    }
                    else
                    {
                        Console.WriteLine("Needn't to update");
                    }
                }
            }
        }
    }
}