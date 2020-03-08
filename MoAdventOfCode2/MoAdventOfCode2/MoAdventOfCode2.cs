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

namespace MoAdventOfCode2
{
    public partial class MoAdventOfCode2 : Form
    {

        public const string AOC_2018_DAY2 = @"C:\AdventOfCode\AOC_2018_day2_input.txt";

        public Dictionary<string, int> boxIdsList = new Dictionary<string,int>();
        
        public MoAdventOfCode2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Calculate the CheckSum for the whole Puzzle Input file
        /// Read through the Puzzle Input file a line at a time (a BoxId)
        /// For each BoxId:-
        ///      Assess if the BoxId contains letters that appear twice
        ///      Assess if the BoxId contains letters that appear three times
        /// Calculate the number of BoxIds with letters that appear twice - totalTwice
        /// Calculate the number of BoxIds with letters that appear three times - totalThreeTimes
        /// Calculate the checkSum as totalTwice * totalThree
        /// </summary>
        private void CalculateCheckSum()
        {
            string boxId = "";
            int totalTwice = 0;
            int totalThreeTimes = 0;
            bool containsTotalTwice;
            bool containsTotalThreeTimes;
            int checkSum = 0;

            using (StreamReader sr = new StreamReader(AOC_2018_DAY2))
            {
                // Read lines from the file until the end of the file is reached.
                while ((boxId = sr.ReadLine()) != null)
                {
                    //Initialise bools
                    containsTotalTwice = false;
                    containsTotalThreeTimes = false;

                    //Assess the current line
                    //Call to AssessBoxID will populate boxIdsList
                    AssessBoxID(boxId);

                    //Assess contents of boxIdsList:-
                    //extract whether boxId contains a count of chars that occur twice
                    //extract whether boxid contains a count of chars that occur three times
                    foreach(string boxidkey in boxIdsList.Keys.ToList())
                    {
                        int boxIdCount = boxIdsList[boxidkey];
                        if (boxIdCount == 2)
                        {
                            //Update containsTotalTwice
                            containsTotalTwice = true;
                        }
                        if (boxIdCount == 3)
                        {
                            //Update containsTotalThreeTimes
                            containsTotalThreeTimes = true;
                        }
                    }

                    if (containsTotalTwice)
                    {
                        //Increment totalTwice
                        totalTwice++;
                    }
                    if (containsTotalThreeTimes)
                    {
                        //Increment totalThreeTimes
                        totalThreeTimes++;
                    }
                }
            }

            //calculate the checksum
            checkSum = totalTwice * totalThreeTimes;

            txtCalculatedCheckSum.Text = checkSum.ToString();

            //Enable cmdFindCommonChars
            cmdFindCommonChars.Enabled = true;
        }

        /// <summary>
        /// Assess each individual BoxId to check if its a correct box Id.
        /// A correct box id will match with the other correct box ids in 25 of the 26 character positions.
        /// The routine uses Two StreamReaders of the Puzzle Input, srOne and srTwo
        /// </summary>
        private void ProcessFindCommonChars()
        {
            int matchingCharCount = 0;
            int nonMatchingCharPosition = 0;
            bool correctBoxIdsFound = false;
            string commonChars = "";

            // Loop on StreamReader - srOne
            using (StreamReader srOne = new StreamReader(AOC_2018_DAY2))
            {
                string boxIdsrOne = "";
                // Read boxIdOne from srOne until the end of the file is reached.
                while (((boxIdsrOne = srOne.ReadLine()) != null) && (!correctBoxIdsFound))
                {
                    // Loop on StreamReader - srTwo
                    using (StreamReader srTwo = new StreamReader(AOC_2018_DAY2))
                    {
                        string boxIdsrTwo = "";
                        // Read boxIdTwo from srTwo until the end of the file is reached.
                        while ((boxIdsrTwo = srTwo.ReadLine()) != null)
                        {
                            // Initialise matchingCharCount & nonMatchingCharPosition
                            matchingCharCount = 0;
                            nonMatchingCharPosition = 0;
                            // Loop 
                            for (int i = 0; i < boxIdsrOne.Length; i++)
                            {
                                // compare char in position i
                                //Console.WriteLine("i = " + i + " boxIdsrOne[i] = [" + boxIdsrOne[i].ToString() + "] boxIdsrTwo[i] = [" + boxIdsrTwo[i].ToString() + "]");
                                if (boxIdsrOne[i].ToString() == boxIdsrTwo[i].ToString())
                                {
                                    // Increment Matching Char Counter
                                    matchingCharCount++;
                                }
                                else
                                {
                                    // Store the Non Matching Character Postion
                                    nonMatchingCharPosition = i;
                                }
                            }
                            // If MatchingCharCount = 25 the correct Box Ids have been found
                            if (matchingCharCount == 25)
                            {
                                Console.WriteLine("boxIdsrOne=" + boxIdsrOne + " boxIdsrTwo=" + boxIdsrTwo + " matchingCharCount=" + matchingCharCount.ToString() + " nonMatchingCharPosition=" + nonMatchingCharPosition.ToString());
                                // Create commonChars from boxIdsrOne and nonMatchingCharPosition
                                commonChars = boxIdsrOne.Substring(0, nonMatchingCharPosition) + boxIdsrOne.Substring(nonMatchingCharPosition + 1);
                                txtCommonCharacters.Text = commonChars;
                                // Set to true so that outer while statement is exited
                                correctBoxIdsFound = true;
                                // Break from inner while statement
                                break;
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Load the Puzzle Input
        /// </summary>
        private void LoadPuzzleInput()
        {
            string boxId = "";
            int lineCount = 0;
            bool containsInvalidFormat = false;

            using (StreamReader sr = new StreamReader(AOC_2018_DAY2))
            {
                // Read lines from the file until the end of the file is reached.
                while ((boxId = sr.ReadLine()) != null)
                {
                    lineCount++;
                    if (!IsValidFormat(boxId))
                    {
                        containsInvalidFormat = true;
                        Console.WriteLine(boxId + " [not all lower case alpha] " + lineCount.ToString());
                    }
                    else
                    {
                        Console.WriteLine(boxId + " [all lower case alpha] " + lineCount.ToString());
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
                //Enable cmdCalculateCheckSum
                cmdCalculateCheckSum.Enabled = true;
            }
        }

        /// <summary>
        /// Check for entry being a string of lower case letters of the alphabet
        /// Check for string containing at least 1 character.
        /// </summary>
        /// <param name="validatedstring"></param>
        /// <returns></returns>
        public static bool IsValidFormat(string validatedstring)
        {
            bool containsLowerCaseAlphaChar = false;
            bool containsNonLowerCaseAlphaChar = false;
            //int charCount = 0;

            foreach (char oChar in validatedstring)
            {
                //Check for a Lower Case Alpha character
                if (Char.IsLower(oChar))
                {
                    containsLowerCaseAlphaChar = true;
                }
                else
                {
                    containsNonLowerCaseAlphaChar = true;
                }
            }

            //Assess validated string
            if (containsLowerCaseAlphaChar && (!containsNonLowerCaseAlphaChar))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AssessBoxID(string boxId)
        {
            Console.WriteLine("AssessBoxID boxId = " + boxId.ToString() + " boxIdsList.count " + boxIdsList.Count.ToString());

            //clear boxIdsList
            boxIdsList.Clear();

            // Loop through chars in 
            foreach (char oChar in boxId)
            {
                if (boxIdsList.ContainsKey(oChar.ToString()) == true)
                {
                    //increment the count for ochar
                    boxIdsList[oChar.ToString()]++;
                }
                else
                {
                    //add oChar to boxIdsList with a count of 1
                    boxIdsList.Add(oChar.ToString(), 1);
                }
            }

        }

        private void cmdcmdCalculateCheckSum_Click(object sender, EventArgs e)
        {
            CalculateCheckSum();
        }

        private void cmdFindCommonChars_Click(object sender, EventArgs e)
        {
            ProcessFindCommonChars();
        }

        private void cmdLoadPuzzleInput_Click(object sender, EventArgs e)
        {
            LoadPuzzleInput();
        }
    }

}
