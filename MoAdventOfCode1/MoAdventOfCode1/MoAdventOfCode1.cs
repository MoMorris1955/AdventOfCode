using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoAdventOfCode1
{
    public partial class MoAdventOfCode1 : Form
    {

        public const string AOC_2018_DAY1 = @"C:\AdventOfCode\AOC_2018_day1_input.txt";
        
        public MoAdventOfCode1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Assess the Resulting Frequency after looping
        /// through the Puzzle Input once
        /// </summary>
        private void ProcessResultingFrequency()
        {
            string sqlLine = "";
            int resultingFrequency = 0;

            using (StreamReader sr = new StreamReader(AOC_2018_DAY1))
            {
                // Read lines from the file until the end of the file is reached.
                while ((sqlLine = sr.ReadLine()) != null)
                {
                    resultingFrequency = resultingFrequency + Convert.ToInt32(sqlLine);
                    Console.WriteLine(sqlLine + "  Resulting Frequency = " + resultingFrequency.ToString());
                }

            }

            txtResultingFrequency.Text = resultingFrequency.ToString();

            //Enable cmdFrequencyReachedTwice
            cmdFrequencyReachedTwice.Enabled = true;
        }

        /// <summary>
        /// Assess the first Resulting Frequency to be reached Twice after looping
        /// through the Puzzle Input more than once (if required).
        /// </summary>
        private void ProcessFrequencyReachedTwice()
        {
            string sqlLine = "";
            int resultingFrequency = 0;
            int firstFrequencyReachedTwice = 0;
            bool foundFrequencyReachedTwice = false;

            // Initialise collection
            List < string > frequencyList = new List<string>();

            // Loop upto 10 times
            for (int loop = 1; loop <= 1000; loop++)
            {
                Console.WriteLine("StartPosition of loop " + loop.ToString() + " frequencyList.count = " + frequencyList.Count.ToString());

                using (StreamReader sr = new StreamReader(AOC_2018_DAY1))
                {
                    // Read lines from the file until the end of the file is reached.
                    while (((sqlLine = sr.ReadLine()) != null) && (!foundFrequencyReachedTwice))
                    {
                        resultingFrequency = resultingFrequency + Convert.ToInt32(sqlLine);

                        // Check collection for resultingFrequency
                        if (frequencyList.Contains(resultingFrequency.ToString()))
                        {
                            Console.WriteLine("loop = " + loop.ToString() + "  sqlLine = " + sqlLine + "  Resulting Frequency = " + resultingFrequency.ToString());
                            foundFrequencyReachedTwice = true;
                            firstFrequencyReachedTwice = resultingFrequency;
                            loop = 10000;
                        }
                        else
                        {
                            //Add resultingFrequency to collection
                            frequencyList.Add(resultingFrequency.ToString());
                        }

                        //Console.WriteLine("loop = " + loop.ToString() + "  sqlLine = " + sqlLine + "  Resulting Frequency = " + resultingFrequency.ToString());
                    }

                }
            }

            txtFrequencyReachedTwice.Text = firstFrequencyReachedTwice.ToString();
        }

        /// <summary>
        /// Load the Puzzle Input
        /// </summary>
        private void LoadPuzzleInput()
        {
            string sqlLine = "";
            int lineCount = 0;
            bool containsInvalidFormat = false;

            using (StreamReader sr = new StreamReader(AOC_2018_DAY1))
            {
                
                // Read lines from the file until the end of the file is reached.
                while ((sqlLine = sr.ReadLine()) != null)
                {
                    lineCount++;
                    if (!IsNumeric(sqlLine))
                    {
                        containsInvalidFormat = true;
                        Console.WriteLine(sqlLine + " [invalid format] " + lineCount.ToString());
                    }
                    else
                    {
                        Console.WriteLine(sqlLine + " [valid format] " + lineCount.ToString());
                    }
                }
            }
            
            if (containsInvalidFormat)
            {
                txtInformation.Text = "Puzzle Input contains invalid entries";
            }
            else
            {
                txtInformation.Text = "Puzzle Input all valid";
                //Enable cmdResultingFrequency
                cmdResultingFrequency.Enabled = true;
            }
        }

        /// <summary>
        /// Check for entry being in the form of:-
        /// First Char '+' or '-'
        /// All Following Char '0123456789'
        /// A check for not containing at least one number is made
        /// </summary>
        /// <param name="validatedstring"></param>
        /// <returns></returns>
        public static bool IsNumeric(string validatedstring)
        {
            bool firstCharPlusOrMinus = false;
            bool containsNumber = false;
            bool containsNonNumeric = false;
            int charCount = 0;

            foreach (char oChar in validatedstring)
            {
                //increment charCount
                charCount++;

                //Only check the first char for '+' or '-'
                if (charCount == 1)
                {
                    if ((oChar.Equals('+')) || (oChar.Equals('-')))
                    {
                        firstCharPlusOrMinus = true;
                    }
                }
                else
                { 
                    //Check for a numeric char
                    if (Char.IsNumber(oChar))
                    {
                        containsNumber = true;
                    }
                    else
                    {
                        containsNonNumeric = true;
                    }
                }
            }

            //Assess validated string
           if (firstCharPlusOrMinus && containsNumber && (!containsNonNumeric))
           {
                return true;
           }
           else
           {
                return false;
           }
        }

        private void cmdResultingFrequency_Click(object sender, EventArgs e)
        {
            ProcessResultingFrequency();
        }

        private void cmdFrequencyReachedTwice_Click(object sender, EventArgs e)
        {
            ProcessFrequencyReachedTwice();
        }

        private void cmdLoadPuzzleInput_Click(object sender, EventArgs e)
        {
            LoadPuzzleInput();
        }
    }

}
