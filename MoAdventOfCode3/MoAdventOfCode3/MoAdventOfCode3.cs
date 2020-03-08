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

namespace MoAdventOfCode3
{
    public partial class MoAdventOfCode3 : Form
    {

        public const string AOC_2018_DAY3 = @"C:\AdventOfCode\AOC_2018_day3_input.txt";

        public int[,] fabricGrid = new int[1000, 1000];
        
        public MoAdventOfCode3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initialize every cell in fabricGrid[x, y] to zero
        /// </summary>
        private void InitializeFabricGrid()
        {
            for (int x = 0; x < 1000; x++)
            {
                for (int y = 0; y < 1000; y++)
                {
                    // set [x,y] to zero
                    fabricGrid[x, y] = 0;
                }
            }
        }

        /// <summary>
        /// Caluculate the total number of squares with multiple claims
        /// </summary>
        private void CalculateSquaresMultipleClaims()
        {
            string fabricId = "";
            int lineCount = 0;
            int idNo = 0;
            int left = 0;
            int top = 0;
            int width = 0;
            int height = 0;
            int totalMultipleClaims = 0;

            // Read through the Puzzle Input
            using (StreamReader sr = new StreamReader(AOC_2018_DAY3))
            {
                // Read lines from the file until the end of the file is reached
                while ((fabricId = sr.ReadLine()) != null)
                {
                    lineCount++;
                    //Console.WriteLine("[" + lineCount.ToString() + "] " + fabricId);
                    // extract the parts of the fabricId idNo, left, top, width & height
                    string[] splitFabricId = fabricId.Split(' ');
                    idNo = Convert.ToInt16(splitFabricId[0].Substring(1));
                    string[] splitPartTwo = splitFabricId[2].Split(',');
                    left = Convert.ToInt16(splitPartTwo[0]);
                    top = Convert.ToInt16(splitPartTwo[1].Substring(0,(splitPartTwo[1].Length -1)));
                    string[] splitPartThree = splitFabricId[3].Split('x');
                    width = Convert.ToInt16(splitPartThree[0]);
                    height = Convert.ToInt16(splitPartThree[1]);
                    //Console.WriteLine("[" + lineCount.ToString() + "] #" + idNo + " @ " + left + "," + top + ": " + width + "x" + height);

                    /// For each fabricId:-
                    ///     From x = left to (left + width)
                    ///         From y = top to (top + height)
                    ///             increment fabricGrid[x, y] + 1
                    
                    for (int x = left; x < (left + width); x++)
                    {
                        for (int y = top; y < (top + height); y++)
                        {
                            fabricGrid[x, y] = fabricGrid[x, y] + 1;

                            //Console.WriteLine(" x=" + x + " y=" + y + " set to " + fabricGrid[x, y].ToString());
                        }
                    }
                }
            }

            /// Calculate the Number of Squares that have Multiple Claims
            /// *********************************************************
            /// Examin the fabricGrid[x,y]
            ///    Loop on x from 0 to 1000
            ///       Loop on y from 0 to 1000
            ///          If fabricGrid[x, y] > 1
            ///             increment totalMultipleClaims + 1
                         
            for (int x = 0; x < 1000; x++)
            {
                for (int y = 0; y < 1000; y++)
                {
                    if (fabricGrid[x, y] > 1)
                    {
                        // increment totalMultipleClaims + 1
                        totalMultipleClaims++;
                    }
                }
            }

            // Display the Number of Squares that have Multiple Claims
            txtNumberSquaresMultipleClaims.Text = totalMultipleClaims.ToString();

            /// Find the idNo of the fabricId that has no overlapping square claims
            /// *******************************************************************
            /// Look for the idNo that has all squares with a Total Claim of One
            /// Loop on each fabricId
            ///     Extract the parts of the fabricId idNo, left, top, width & height
            ///     set allSquaresEqualOne =
            ///     From x = left to (left + width)
            ///         From y = top to (top + height)
            ///             If fabricGrid[x, y] = 1               
            
            int idNoNoOverlaps = 0;
            bool containsMultipleClaims;
            bool noMultipleClaims;
            bool containsSquareWithClaimOfOne;
            lineCount = 0;

            // Read through the Puzzle Input
            using (StreamReader sr = new StreamReader(AOC_2018_DAY3))
            {
                // Read lines from the file until the end of the file is reached
                while ((fabricId = sr.ReadLine()) != null)
                {
                    lineCount++;
                    //Console.WriteLine("[" + lineCount.ToString() + "] " + fabricId);
                    // extract the parts of the fabricId idNo, left, top, width & height
                    string[] splitFabricId = fabricId.Split(' ');
                    idNo = Convert.ToInt16(splitFabricId[0].Substring(1));
                    string[] splitPartTwo = splitFabricId[2].Split(',');
                    left = Convert.ToInt16(splitPartTwo[0]);
                    top = Convert.ToInt16(splitPartTwo[1].Substring(0, (splitPartTwo[1].Length - 1)));
                    string[] splitPartThree = splitFabricId[3].Split('x');
                    width = Convert.ToInt16(splitPartThree[0]);
                    height = Convert.ToInt16(splitPartThree[1]);
                    //Console.WriteLine("[" + lineCount.ToString() + "] #" + idNo + " @ " + left + "," + top + ": " + width + "x" + height);

                    containsMultipleClaims = false;
                    noMultipleClaims = true;
                    containsSquareWithClaimOfOne = false;

                    for (int x = left; x < (left + width); x++)
                    {
                        for (int y = top; y < (top + height); y++)
                        {
                            //Console.WriteLine(" x=" + x + " y=" + y + " set to " + fabricGrid[x, y].ToString());
                            if (fabricGrid[x, y] == 1)
                            {
                                // set containsSquareWithClaimOfOne to true
                                containsSquareWithClaimOfOne = true;
                            }
                            else
                            {
                                // set containsMultipleClaims to true
                                containsMultipleClaims = true;
                                // set noMultipleClaims to false
                                noMultipleClaims = false;
                            }
                        }
                    }

                    // Assess if this fabricId.idNo that has all squares with a Total Claim of One
                    if ((containsSquareWithClaimOfOne) && (noMultipleClaims) && (!containsMultipleClaims))
                    {
                        // store idNo of fabricId that has all squares with a Total Claim of One
                        idNoNoOverlaps = idNo;
                    }
                }
            }

            // Display the idNo that has all squares with a Total Claim of One
            txtNoOverlaps.Text = idNoNoOverlaps.ToString();
        }

        /// <summary>
        /// Load and validate the Puzzle Input file of fabricId
        /// 
        /// Format of a fabricId: -
        ///          1         2         3
        /// 123456789012345678901234567890
        /// #9999 @ 999,999: 99x99
        ///
        /// #idNo @ left , top: width x height
        /// 
        /// </summary>
        private void LoadPuzzleInput()
        {
            string fabricId = "";
            int lineCount = 0;
            bool containsInvalidFormat = false;

            using (StreamReader sr = new StreamReader(AOC_2018_DAY3))
            {
                // Read lines from the file until the end of the file is reached.
                while ((fabricId = sr.ReadLine()) != null)
                {
                    lineCount++;
                    if (!IsValidFormat(fabricId))
                    {
                        containsInvalidFormat = true;
                        //Console.WriteLine(fabricId + " [Invalid file format] " + lineCount.ToString());
                    }
                    else
                    {
                        //Console.WriteLine(fabricId + " [Valid file format] " + lineCount.ToString());
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
                cmdCalculateSquaresMultipleClaims.Enabled = true;
            }
        }

        /// <summary>
        /// Check entry for being a valid fabricId.
        /// Format of a fabricId: -
        ///          1         2         3
        /// 123456789012345678901234567890
        /// #9999 @ 999,999: 99x99
        ///
        /// #idNo @ left , top: width x height
        /// </summary>
        /// <param name="validatedstring"></param>
        /// <returns></returns>
        public static bool IsValidFormat(string fabricId)
        {
            bool validSplit = false;
            bool part0Valid = false;
            bool part1Valid = false;
            bool part2Valid = false;
            bool part3Valid = false;
           
            // Split fabricId into parts
            string[] splitFabricId = fabricId.Split(' ');

            // Check that the number of parts after the Split on ' '
            if (splitFabricId.Length != 4)
            {
                validSplit = false;
            }
            else
            {
                // Validate the idividual parts
                validSplit = true;

                part0Valid = ValidatePartZero(splitFabricId[0]);

                part1Valid = ValidatePartOne(splitFabricId[1]);

                part2Valid = ValidatePartTwo(splitFabricId[2]);

                part3Valid = ValidatePartThree(splitFabricId[3]);

            }
            // Assess the validation of the fabricId
            if ((validSplit) && (part0Valid) && (part1Valid) && (part2Valid) && (part3Valid))
            {
                // set fabricId to valid
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validate stringPart[0] - "#999"
        /// </summary>
        /// <param name="partZero"></param>
        /// <returns></returns>
        public static bool ValidatePartZero(string partZero)
        {
            int charCount = 0;
            bool firstCharHash = false;
            bool containsNumber = false;
            bool containsNonNumeric = false;
            foreach (char oChar in partZero)
            {
                charCount++;
                // Check first char is "#"
                if (charCount == 1)
                {
                    if (oChar.Equals('#'))
                    {
                        firstCharHash = true;
                    }
                }
                else
                {
                    // Check for a numeric char
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
            // Assess the validation of splitFabricId[0] - "#999"
            if ((firstCharHash) && (containsNumber) && (!containsNonNumeric))
            {
                // set part0Valid to valid
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validate splitFabricId[1] - "@"
        /// </summary>
        /// <param name="partOne"></param>
        /// <returns></returns>
        public static bool ValidatePartOne(string partOne)
        {
            if (partOne[0].Equals('@'))
            {
                // set part1Valid to valid
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validate splitFabricId[2] - "999,999:"
        /// </summary>
        /// <param name="partTwo"></param>
        /// <returns></returns>
        public static bool ValidatePartTwo(string partTwo)
        {
            bool validsplit = false;
            bool partTwoPart0Valid = false;
            bool partTwoPart1Valid = false;
            
            // Split partTwo on ','
            string[] splitPartTwo = partTwo.Split(',');

            // Check that partTwo has split into 2 parts
            if (splitPartTwo.Length != 2)
            {
                validsplit = false;
            }
            else
            {
                // Validate the individual parts
                validsplit = true;

                partTwoPart0Valid = ValidatePartTwo0(splitPartTwo[0]);

                partTwoPart1Valid = ValidatePartTwo1(splitPartTwo[1]);
            }
            // Asses the validation of splitFabricId[2] - "999,999:"
            if ((validsplit) && (partTwoPart0Valid) && (partTwoPart1Valid))
            {
                // set partTwo to valid
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// validate "999"
        /// </summary>
        /// <param name="partTwo0"></param>
        /// <returns></returns>
        public static bool ValidatePartTwo0(string partTwo0)
        {
            bool containsNumber = false;
            bool containsNonNumeric = false;

            foreach (char oChar in partTwo0)
            {
                if (char.IsNumber(oChar))
                {
                    containsNumber = true;
                }
                else
                {
                    containsNonNumeric = true;
                }
            }
            // Assess the validation of partTwo0
            if ((containsNumber)  && (!containsNonNumeric))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validate "999:"
        /// </summary>
        /// <param name="partTwo1"></param>
        /// <returns></returns>
        public static bool ValidatePartTwo1(string partTwo1)
        {
            bool lastCharColon = false;
            bool containsNumber = false;
            bool containsNonNumeric = false;
            int charCount = 0;
            int charLength = partTwo1.Length;

            foreach (char oChar in partTwo1)
            {
                charCount++;
                // Skip last char of ":"
                if (charCount != charLength)
                {
                    if (char.IsNumber(oChar))
                    {
                        containsNumber = true;
                    }
                    else
                    {
                        containsNonNumeric = true;
                    }
                }
                else
                {
                    //check last char is ":"
                    if (oChar.Equals(':'))
                    {
                        lastCharColon = true;
                    }
                }
            }
            // Assess the validation of partTwo1
            if ((lastCharColon) && (containsNumber) && (!containsNonNumeric))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validate splitFabricId[3] - "99x99"
        /// </summary>
        /// <param name="partThree"></param>
        /// <returns></returns>
        public static bool ValidatePartThree(string partThree)
        {
            bool validsplit = false;
            bool partTwoPart0Valid = false;
            bool partTwoPart1Valid = false;

            // Split partThree on 'x'
            string[] splitPartThree = partThree.Split('x');

            // Check that partTwo has split into 2 parts
            if (splitPartThree.Length != 2)
            {
                validsplit = false;
            }
            else
            {
                // Validate the individual parts
                validsplit = true;

                partTwoPart0Valid = ValidatePartThree0And1(splitPartThree[0]);

                partTwoPart1Valid = ValidatePartThree0And1(splitPartThree[1]);
            }
            // Asses the validation of splitFabricId[2] - "999,999:"
            if ((validsplit) && (partTwoPart0Valid) && (partTwoPart1Valid))
            {
                // set partTwo to valid
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Validate PartThree0 & PartThree1
        /// </summary>
        /// <param name="partTwo0"></param>
        /// <returns></returns>
        public static bool ValidatePartThree0And1(string partThree0And1)
        {
            bool containsNumber = false;
            bool containsNonNumeric = false;

            foreach (char oChar in partThree0And1)
            {
                if (char.IsNumber(oChar))
                {
                    containsNumber = true;
                }
                else
                {
                    containsNonNumeric = true;
                }
            }
            // Assess the validation of PartThree0 & PartThree1
            if ((containsNumber) && (!containsNonNumeric))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdCalculateSquaresMultipleClaims_Click(object sender, EventArgs e)
        {
            CalculateSquaresMultipleClaims();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLoadPuzzleInput_Click(object sender, EventArgs e)
        {
            InitializeFabricGrid();
            LoadPuzzleInput();
        }
    }

}
