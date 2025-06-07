using System.Diagnostics;
using System.Xml.Linq;

namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine(SpiderPath());
            


        }
        public static string SpiderPath()
        {
            //Structure of spider web
            List<char> Nodes = new List<char> { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H' };
            List<int> Levels = new List<int> { 0, 1, 2, 3, 4 };

            //location of spider and fly
            string spider = "H4";
            string fly = "A0";

            //destruct spider location
            char s_Node = spider[0];
            int s_Level = int.Parse(spider[1].ToString());
            //destruct fly location
            char f_Node = fly[0];
            int f_Level = int.Parse(fly[1].ToString());

            //the path to reach the fly
            string result = "";

            
            //reverse node list when s_node-f_node<=4 || s_node-f_node<-4
            //not reverse node list when s_node-f_node>4
            //to traverse from node to other, especially when first node is in last element of array
            if ((Nodes.IndexOf(s_Node) - Nodes.IndexOf(f_Node)) <= 4 || (Nodes.IndexOf(s_Node) - Nodes.IndexOf(f_Node)) < -4)
            {
                Nodes.Reverse();

            }




            //check if levels are higher than level 1
            if ( (s_Level > 1&& f_Level >1))
            {
                //if they are on level 2 and above it is better to traverse by nodes first then by level
                for (int i = Nodes.IndexOf(s_Node); i < Nodes.Count; i++)
                {
                    result += Nodes[i].ToString() + s_Level;
                    //if they are on same node
                    if (i == Nodes.IndexOf(f_Node))
                    {
                        int temp = s_Level;
                        //traverse by level
                        for (int j = 0; j < Levels.Count; j++)
                        {
                            if (temp == f_Level)
                            {
                                return result;
                            }
                            else if (temp > f_Level)
                            {
                                temp--;
                                result += "-" + Nodes[i].ToString() + temp;
                            }
                            else
                            {
                                temp++;
                                result += "-" + Nodes[i].ToString() + temp;
                            }
                        }
                    }
                    result += "-";
                    if (i == 7)
                    {
                        i = -1;
                    }
                }
            }
            //if fly or spider at the center of web
            else if (s_Level == 0 || f_Level == 0)
            {
                result += spider;
                int temp = s_Level;
                //traverse by level
                for (int j = 0; j < Levels.Count; j++)
                {
                    if (temp == f_Level)
                    {
                        return result;
                    }
                    else if (temp > f_Level)
                    {
                        temp--;
                        if (temp == 0)
                        {
                            result += "-A0" ;
                        }
                        else
                        {
                        result += "-" + s_Node.ToString() + temp;
                        }
                    }
                    else
                    {
                        temp++;
                        result += "-" + f_Node.ToString() + temp;
                    }
                }
            }
            //if spider and/or fly are in level 1 or 0
            else
            {
                //if spider and fly in level 1
                if (s_Level - f_Level == 0)
                {
                    //if spider and fly 1 node apart
                    if (Math.Abs(Nodes.IndexOf(s_Node) - Nodes.IndexOf(f_Node)) == 1 || Math.Abs(Nodes.IndexOf(s_Node) - Nodes.IndexOf(f_Node)) == 7)
                    {
                        //traverse by node
                        result += spider+"-" + fly;
                        return result;
                    }
                    else
                    {
                        //move through center of web 
                        result += spider+"-A0-" + fly;
                        return result;

                    }
                }
                //if spider or fly are in 1 level
                //example: if spider=h1 and fly=d4 or opposite 
                else
                {
                    
                    result += spider;
                    int temp = s_Level;
                    bool check=false;
                    if (s_Level == 1)
                    {
                        temp = 0;
                        result += "-A0";
                        check = true;
                    }
                    else 
                    { 

                    }
                    //traverse by level
                    for (int j = 0; j < Levels.Count*2; j++)
                    {
                        if (temp == f_Level&& check)
                        {
                            return result;
                        }
                        else if (temp >= f_Level)
                        {
                            temp--;
                            if (temp == 0)
                            {
                                result += "-A0";
                                check=true;
                            }
                            else
                            {
                                result += "-" + s_Node.ToString() + temp;
                            }
                        }
                        else
                        {
                            temp++;
                            result += "-" + f_Node.ToString() + temp;
                        }
                    }
                    return result;
                }


            }
            return result;
        }
    }
}
