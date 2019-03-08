using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P31
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var userinput = Console.ReadLine();
            if (userinput == "1")
            {
                string star1 = "*";
                var n1 = Double.Parse(Console.ReadLine());
                for (int i1 = 1; i1 <= n1; i1++)
                {
                    Console.WriteLine(star1);
                    star1 = star1 + "*";
                }
            }

            if(userinput == "2"){
                var star2 = "";
                var space2 = "";
                int count = 1;
                var n2 = Double.Parse(Console.ReadLine());
                for (var i2= n2; i2 >=1; i2--)
                {
                    space2 = "";
                    star2 = "";
                    Console.WriteLine(" ");
                    for(var spacecreate=1; spacecreate <= n2-count; spacecreate++)
                    {
                        space2 = space2 + " ";
                    }
                    for(var j2=1; j2 <=count; j2++)
                    {
                        star2 = star2 + "*";
                    }
                    Console.WriteLine(space2+star2);
                    count += 1;

                }
            }


            if (userinput == "3")
            {
                string star3 = "*";
                string space3 = "";
                //string space32 = "";
                
                var n3 = int.Parse(Console.ReadLine())+1;
                int totalspace = n3+n3-1;
                string[] display = new string[totalspace];
                for (var fill=0; fill<display.Length; fill++)
                {
                    display[fill] = " ";
                }
                string outputdisplay;
                int num1 = totalspace / 2;
                int num2 = (totalspace / 2) + 2;
                display[n3] = "*";
                outputdisplay = string.Join("", display);
                Console.WriteLine(outputdisplay);
                display[n3] = " ";
                for (var i3 = 1; i3 < n3-1; i3++)
                {
                    display[num1] = "*";
                    display[num2] = "*";

                    outputdisplay = string.Join("", display);
                    Console.WriteLine(outputdisplay);
                    
                    display[num1] = " ";
                    display[num2] = " ";
                    num1 -= 1;
                    num2 += 1;
                }

                //last row
                outputdisplay = string.Join("", display);
                Console.WriteLine(outputdisplay);

            }

            if(userinput == "4")
            {
                var n4 = int.Parse(Console.ReadLine())+1;

                int totalspace1 = n4 - 1;
                string[] display1 = new string[totalspace1];

                for (var fill1 = 0; fill1 < display1.Length; fill1++)
                {
                    display1[fill1] = " ";
                }

                int numstart = 0;
                int numend = totalspace1-1;
                string outdisplay1;
                int flag = 0;
                for (int i4=0; i4<totalspace1; i4++)
                {
                    //if(totalspace1 % 2 == 0)
                    //{
                        if (flag == 0)
                        {
                            display1[numstart] = "*";
                            display1[numend] = "*";
                            outdisplay1 = string.Join("", display1);
                            Console.WriteLine(outdisplay1);
                            display1[numstart] = " ";
                            display1[numend] = " ";
                            numstart += 1;
                            numend -= 1;

                            if (numstart == numend) flag = 1;
                        }
                        if (flag == 1)
                        {
                            display1[numstart] = "*";
                            display1[numend] = "*";
                            outdisplay1 = string.Join("", display1);
                            Console.WriteLine(outdisplay1);
                            display1[numstart] = " ";
                            display1[numend] = " ";
                            numstart -= 1;
                            numend += 1;
                        }
                    //}
                    
                    

               }


            }

            if(userinput == "5")
            {
                /*
                 NOTE Only works for even number
                 */
                var n5 = int.Parse(Console.ReadLine()) + 1;

                int totalspace5 = n5 - 1;
                string[] display5 = new string[totalspace5];
                List<string> overallout = new List<string>();
                for (var fill5 = 0; fill5 < display5.Length; fill5++)
                {
                    display5[fill5] = " ";
                }

                int flag5 = 0;
                int center = (totalspace5 / 2) + 1;
                string outdisplay5;
                int startnum = center;
                int endnum = center;
                for (int i5=0; i5<totalspace5/2; i5++)
                {

                    for (int j5=startnum; j5<=endnum; j5++)
                    {
                        display5[j5] = "*";
                    }
                    startnum -= 1;
                    endnum += 1;
                    outdisplay5 = string.Join("",display5);
                    overallout.Add(outdisplay5);
                    //Console.WriteLine(outdisplay5);

                }

                foreach (var overall in overallout)
                {
                    Console.WriteLine(overall);
                }

                overallout.Reverse();

                foreach (var overall in overallout)
                {
                    Console.WriteLine(overall);
                }


            }
           
            
        }
    }
}
