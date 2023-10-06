using System.Linq;
using System.Text;

//-----------------------------------------------
string[] besaidFights = { "zzzz00_09", "zzzz00_28", "zzzz00_16"};
string[] kilikaFights = { "zzzz00_22", "zzzz00_31", "zzzz00_77", "zzzz00_39" };
string[] miihenHighRoadFights = { "zzzz00_10", "zzzz00_23", "zzzz00_35", "zzzz00_78", "zzzz00_01", "zzzz00_59", "zzzz00_193", "zzzz00_55" };
string[] mushroomRockRoadFights = { "zzzz00_24", "zzzz00_06", "zzzz00_17", "zzzz00_79", "zzzz00_60", "zzzz00_214", "zzzz00_44" };
string[] djoseRoadFights = { "zzzz00_11", "zzzz00_29", "zzzz00_32", "zzzz00_18", "zzzz00_02", "zzzz00_185", "zzzz00_189" };
string[] thunderPlainsFights = { "zzzz00_25", "zzzz00_07", "zzzz00_36", "zzzz00_80", "zzzz00_61", "zzzz00_209", "zzzz00_181", "zzzz00_207" };
string[] macalaniaFights = { "zzzz00_12", "zzzz00_26", "zzzz00_33", "zzzz00_37", "zzzz00_19", "zzzz00_81", "zzzz00_03", "zzzz00_04",
                             "zzzz00_217", "zzzz00_87"};
string[] bikanelFights = { "zzzz00_13", "zzzz00_30", "zzzz00_62", "zzzz00_45", "zzzz00_46", "zzzz00_208" };
string[] calmLandsFights = { "zzzz00_14", "zzzz00_34", "zzzz00_20", "zzzz00_05", "zzzz00_186", "zzzz00_66", "zzzz00_89", "zzzz00_88",
                             "zzzz00_64" };
string[] stolenFaythCavernFights = { "zzzz00_27", "zzzz00_08", "zzzz00_82", "zzzz00_63", "zzzz00_215", "zzzz00_56", "zzzz00_84", "zzzz00_50",
                                     "zzzz00_223" };
string[] mtGagazetFights = { "zzzz00_15", "zzzz00_38", "zzzz00_21", "zzzz00_194", "zzzz00_40", "zzzz00_57", "zzzz00_67", "zzzz00_190",
                             "zzzz00_85" };
string[] insideSinFights = { "zzzz00_216", "zzzz00_220", "zzzz00_182", "zzzz00_184", "zzzz00_95", "zzzz00_65", "zzzz00_210", "zzzz00_187",
                             "zzzz00_86" };
string[] omegaDungeonFights = { "zzzz00_239", "zzzz00_242", "zzzz00_83", "zzzz00_240", "zzzz00_218", "zzzz00_219", "zzzz00_244", "zzzz00_90",
                                "zzzz00_224", "zzzz00_188" };
//-----------------------------------------------
string[] areaConquestFights = { "zzzz03_00", "zzzz03_04", "zzzz03_05", "zzzz03_09", "zzzz03_11", "zzzz03_14", "zzzz03_18", "zzzz03_01",
                                "zzzz03_08", "zzzz03_17", "zzzz03_07", "zzzz03_12", "zzzz03_15" };
string[] speciesConquestFights = { "zzzz02_94", "zzzz02_96", "zzzz02_97", "zzzz02_98", "zzzz02_93", "zzzz02_99", "zzzz02_95", "zzzz03_06",
                                   "zzzz02_92", "zzzz03_03", "zzzz03_16", "zzzz03_13", "zzzz03_02", "zzzz03_10" };
string[] originalBossFights = { "zzzz02_79", "zzzz02_81", "zzzz02_77", "zzzz02_82", "zzzz00_105", /*"zzzz02_80", */"zzzz02_76" };
string[] waterFights = { "zzzz00_73", "zzzz00_52", "zzzz00_54" };
//string[] shinryuFight = { "zzzz02_83" };        Unused. Causes crashes.
//-----------------------------------------------
string[] vanillaDarkAeonFights = { "bsil07_70", "bika03_70", "dome06_70", "kami03_70", "kami03_71", "mcyt00_70", "mtgz01_70", "nagi05_70",
                            "nagi05_71", "nagi05_72", "nagi05_73", "nagi05_74", "kino00_70", "kino01_70", "kino01_71", "kino01_72",
                            "kino05_70", "kino05_71"};
//-----------------------------------------------
string[] vanillaRegularFights = besaidFights.Concat(kilikaFights).Concat(miihenHighRoadFights).Concat(mushroomRockRoadFights)
                                             .Concat(djoseRoadFights).Concat(thunderPlainsFights).Concat(macalaniaFights)
                                             .Concat(bikanelFights).Concat(calmLandsFights).Concat(stolenFaythCavernFights)
                                             .Concat(mtGagazetFights).Concat(insideSinFights).Concat(omegaDungeonFights).ToArray();
string[] vanillaSpecialFights = areaConquestFights.Concat(speciesConquestFights).Concat(originalBossFights).ToArray();
string[] vanillaCreatureFights = vanillaRegularFights.Concat(vanillaSpecialFights).ToArray();
string[] vanillaEverythingFights = vanillaCreatureFights.Concat(vanillaDarkAeonFights).ToArray();
string[] vanillaWaterFights = waterFights;
//-----------------------------------------------
string?[] userInput = new string[5];
int[] userInputInt = new int[3];
string baseFolderPath = "\\ffx_ps2\\ffx\\master\\jppc\\battle\\btl";
int missingFolders = 0;
string[] missingFolderPaths = new string[vanillaEverythingFights.Length];
byte[] myByteArray = new byte[10];
byte[] myByteArray2 = new byte[10];
byte fileGotByte;
int foreachBuffer = 0;
int finishedFiles = 0;
string[] yesOrNo = { "Yes", "No" };

if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Input\\"))
{
    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Input\\");
}
if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "Output\\"))
{
    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\");
}

INVALIDSELECTION:
    Console.WriteLine("Welconme to the FFX creature Randomizer!\nSelect an option below to get started.\nNotice: Both Ultima Buster and Shinryu are excluded from randomization.\n\n"
                    + "\n1. Shuffle Monster Arena(capturable)"
                    + "\n2. Shuffle Monster Arena(non-capturable)"
                    + "\n3. Shuffle Monster Arena(everything)"
                    + "\n4. Shuffle Dark Aeons"
                    + "\n5. Anything Goes(limited to what can be shuffled)");
    userInput[0] = Console.ReadLine();
    if (userInput[0] == null || (int.TryParse(userInput[0], out userInputInt[0]) && (userInputInt[0] < 1 || userInputInt[0] > 5)))
    {
        Console.Clear();
        Console.WriteLine("Input is invalid. Use a number between 1-5");
        goto INVALIDSELECTION;
    }

    Console.Clear();

CANNOTPARSE:
    Console.WriteLine("Use a number here for seeded generation.\nLeave blank for completely random seed.");
    userInput[1] = Console.ReadLine();
    if (userInput[1] == null || userInput[1] == "")
    {
        Random randSeed = new Random();
        userInputInt[1] = randSeed.Next();
        userInput[3] = "Random ~ Will be shown after the randomization process";
    }
    else
    {
        if (int.TryParse(userInput[1], out userInputInt[1]) && userInputInt[1] > int.MaxValue)
        {
            try
            {
                long newLongVariable;
                long.TryParse(userInput[1], out newLongVariable);
                if (newLongVariable > int.MaxValue)
                {
                    userInputInt[1] = (int)(newLongVariable - int.MaxValue);
                }
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Couldn't read the value. Value is too large for a seed.\nUse a number from 1-" + int.MaxValue);
                goto CANNOTPARSE;
            }
        }
        userInput[3] = userInputInt[1].ToString();
    }
INCORRECTDIRECTORY:
    Console.Clear();
    Console.WriteLine("Specify a location where your battle files are stored.\nLeave blank to use the \"Input\" folder");
    userInput[2] = Console.ReadLine();
    missingFolders = 0;
    if (userInput[2] == null || userInput[2] == "")
    {
        userInput[2] = AppDomain.CurrentDomain.BaseDirectory + "Input\\";
    }
    else
    {
        if (!Directory.Exists(userInput[2]))
        {
            goto INCORRECTDIRECTORY;
        }
        else
        {
            for (int i = 0; i < vanillaEverythingFights.Length; i++)
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Input\\" + baseFolderPath + "\\" + vanillaEverythingFights[i] + "\\"))
                {
                    missingFolderPaths[missingFolders] = AppDomain.CurrentDomain.BaseDirectory + "\\Input\\" + baseFolderPath + "\\" + vanillaEverythingFights[i] + "\\";
                    missingFolders++;
                }
            }
            if (missingFolders > 0)
            {
                Console.Clear();
                Console.WriteLine("Missing required folder directories for randomization.\nCheck \"paths.txt\" for more information. Make sure those files exist too. :)\n\n");
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "paths.txt"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "paths.txt");
                }
                using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "paths.txt"))
                {
                    for (int i = 0; i < missingFolderPaths.Length; i++)
                    {
                        writer.WriteLine(missingFolderPaths[i]);
                    }
                }
                goto INCORRECTDIRECTORY;
            }
            missingFolders = 0;
            for (int i = 0; i < vanillaEverythingFights.Length; i++)
            {
                if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Input\\" + baseFolderPath + "\\" + vanillaEverythingFights[i] + "\\" + vanillaEverythingFights[i] + ".bin"))
                {
                    missingFolderPaths[missingFolders] = AppDomain.CurrentDomain.BaseDirectory + "\\Input\\" + baseFolderPath + "\\" + vanillaEverythingFights[i] + "\\" + vanillaEverythingFights[i] + ".bin";
                    missingFolders++;
                }
            }
            if (missingFolders > 0)
            {
                Console.Clear();
                Console.WriteLine("Missing required files for randomization.\nCheck \"paths.txt\" for more information.\n\n");
                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "paths.txt"))
                {
                    File.Delete(AppDomain.CurrentDomain.BaseDirectory + "paths.txt");
                }
                using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "paths.txt"))
                {
                    for (int i = 0; i < missingFolderPaths.Length; i++)
                    {
                        writer.WriteLine(missingFolderPaths[i]);
                    }
                }
                goto INCORRECTDIRECTORY;
            }
        }
    }

    Console.Clear();
    Console.WriteLine("Generate a seed folder? Leave blank for No.\n\n1. Yes\n2. No");

    userInput[4] = Console.ReadLine();
    if (userInput[4] == null || userInput[4] == "")
    {
        userInputInt[2] = 2;
    }
    else
    {
        if (userInput[4] == "1" || userInput[4] == "2")
        {
            int.TryParse(userInput[4], out userInputInt[2]);
        }
    }

    Console.Clear();
    Console.WriteLine("Review the following information is right.\nThen press any key when ready to generate...\n\n"
                    + "Generation: " + userInputInt[0].ToString()
                    + "\nSeed: " + userInput[3]
                    + "\nOriginal Files Directory: " + userInput[2]
                    + "\nGenerate Seed Text File: " + yesOrNo[userInputInt[2] - 1]);
    Console.ReadKey();
    Console.Clear();
//----------------------------------------
Random rand = new Random(userInputInt[1]);

for (int phat = 0; phat < 2; phat++)
{
    switch (userInputInt[0])        //NOTE: Fix internal file structure with patches to better enable higher compatibility with gameplay.
    {
        case 1:             //1. Shuffle Monster Arena(capturable)
            //shuffledRegularFights
            string[] shuffledRegularFights = new string[vanillaRegularFights.Length];    //5. Anything Goes(limited to what can be shuffled)
            for (int i = 0; i < vanillaRegularFights.Length; i++)
            {
                shuffledRegularFights[i] = vanillaRegularFights[i];
            }
            for (int i = 0; i < shuffledRegularFights.Length; i++)
            {
                int r = rand.Next(i, shuffledRegularFights.Length);
                (shuffledRegularFights[r], shuffledRegularFights[i]) = (shuffledRegularFights[i], shuffledRegularFights[r]);
            }
            string[] shuffledWaterFights1 = new string[waterFights.Length];
            for (int i = 0; i < waterFights.Length; i++)
            {
                shuffledWaterFights1[i] = waterFights[i];
            }
            for (int loopy = 0; loopy < 10; loopy++)
            {
                for (int i = 0; i < shuffledWaterFights1.Length; i++)
                {
                    int r = rand.Next(i, shuffledWaterFights1.Length);
                    (shuffledWaterFights1[r], shuffledWaterFights1[i]) = (shuffledWaterFights1[i], shuffledWaterFights1[r]);
                }
            }
            shuffledRegularFights = shuffledRegularFights.Concat(shuffledWaterFights1).ToArray();
            FileStream fileStreamOriginal1;
            FileStream fileStreamNew1;
            for (int i = 0; i < shuffledRegularFights.Length; i++)
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledRegularFights[i] + "\\"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledRegularFights[i] + "\\");
                }
                fileStreamOriginal1 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Input\\" + baseFolderPath + "\\" + vanillaRegularFights[i] + "\\" + vanillaRegularFights[i] + ".bin", FileMode.Open, FileAccess.Read);
                fileStreamNew1 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledRegularFights[i] + "\\" + shuffledRegularFights[i] + ".bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fileStreamOriginal1.CopyTo(fileStreamNew1);
                fileStreamOriginal1.Dispose();
                fileStreamOriginal1.Close();
                foreachBuffer = 0;
                for (int thisLoop = 0; thisLoop < myByteArray.Length; thisLoop++)
                {
                    myByteArray[thisLoop] = 0x00;
                    myByteArray2[thisLoop] = 0x00;
                }
                foreach (char filenameCharacter in vanillaRegularFights[i])
                {
                    myByteArray[foreachBuffer] = (byte)filenameCharacter;
                    foreachBuffer++;
                }
                foreachBuffer = 0;
                foreach (char filenameCharacter in shuffledRegularFights[i])
                {
                    myByteArray2[foreachBuffer] = (byte)filenameCharacter;
                    foreachBuffer++;
                }
                if (myByteArray[9] <= 0xFF && myByteArray[9] > 0x00)
                {

                }
                else
                {
                    myByteArray[9] = 0x00;
                }
                if (myByteArray2[9] <= 0xFF && myByteArray2[9] > 0x00)
                {

                }
                else
                {
                    myByteArray2[9] = 0x00;
                }
                for (int positionInt = 0; positionInt < fileStreamNew1.Length - myByteArray.Length + 1; positionInt++)
                {
                    fileStreamNew1.Position = positionInt;
                    fileGotByte = (byte)fileStreamNew1.ReadByte();
                    if (myByteArray[0] == fileGotByte)
                    {
                        fileGotByte = (byte)fileStreamNew1.ReadByte();
                        if (myByteArray[1] == fileGotByte)
                        {
                            fileGotByte = (byte)fileStreamNew1.ReadByte();
                            if (myByteArray[2] == fileGotByte)
                            {
                                fileGotByte = (byte)fileStreamNew1.ReadByte();
                                if (myByteArray[3] == fileGotByte)
                                {
                                    fileStreamNew1.Position = positionInt;
                                    fileStreamNew1.Write(myByteArray2);
                                }
                            }
                        }
                    }
                }
                fileStreamNew1.Dispose();
                fileStreamNew1.Close();
                finishedFiles++;
                Console.Write("\r{0}/{1}", finishedFiles, shuffledRegularFights.Length);
            }
            if (userInputInt[2] == 1)
            {
                using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "seed.txt"))
                {
                    Console.WriteLine("\nWriting seed to file...");
                    writer.WriteLine("Seed: " + userInputInt[1]);
                    writer.WriteLine("Encounter ------> Replaced Encounter");
                    for (int i = 0; i < vanillaEverythingFights.Length; i++)
                    {
                        writer.WriteLine(vanillaRegularFights[i] + " ------> " + shuffledRegularFights[i]);
                    }
                }
            }
            break;
        case 2:             //2. Shuffle Monster Arena(non-capturable)
            //shuffledSpecialFights
            string[] shuffledSpecialFights = new string[vanillaSpecialFights.Length];    //5. Anything Goes(limited to what can be shuffled)
            for (int i = 0; i < vanillaSpecialFights.Length; i++)
            {
                shuffledSpecialFights[i] = vanillaSpecialFights[i];
            }
            for (int i = 0; i < shuffledSpecialFights.Length; i++)
            {
                int r = rand.Next(i, shuffledSpecialFights.Length);
                (shuffledSpecialFights[r], shuffledSpecialFights[i]) = (shuffledSpecialFights[i], shuffledSpecialFights[r]);
            }
            FileStream fileStreamOriginal2;
            FileStream fileStreamNew2;
            for (int i = 0; i < shuffledSpecialFights.Length; i++)
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledSpecialFights[i] + "\\"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledSpecialFights[i] + "\\");
                }
                fileStreamOriginal2 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Input\\" + baseFolderPath + "\\" + vanillaSpecialFights[i] + "\\" + vanillaSpecialFights[i] + ".bin", FileMode.Open, FileAccess.Read);
                fileStreamNew2 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledSpecialFights[i] + "\\" + shuffledSpecialFights[i] + ".bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fileStreamOriginal2.CopyTo(fileStreamNew2);
                fileStreamOriginal2.Dispose();
                fileStreamOriginal2.Close();
                foreachBuffer = 0;
                for (int thisLoop = 0; thisLoop < myByteArray.Length; thisLoop++)
                {
                    myByteArray[thisLoop] = 0x00;
                    myByteArray2[thisLoop] = 0x00;
                }
                foreach (char filenameCharacter in vanillaSpecialFights[i])
                {
                    myByteArray[foreachBuffer] = (byte)filenameCharacter;
                    foreachBuffer++;
                }
                foreachBuffer = 0;
                foreach (char filenameCharacter in shuffledSpecialFights[i])
                {
                    myByteArray2[foreachBuffer] = (byte)filenameCharacter;
                    foreachBuffer++;
                }
                if (myByteArray[9] <= 0xFF && myByteArray[9] > 0x00)
                {

                }
                else
                {
                    myByteArray[9] = 0x00;
                }
                if (myByteArray2[9] <= 0xFF && myByteArray2[9] > 0x00)
                {

                }
                else
                {
                    myByteArray2[9] = 0x00;
                }
                for (int positionInt = 0; positionInt < fileStreamNew2.Length - myByteArray.Length + 1; positionInt++)
                {
                    fileStreamNew2.Position = positionInt;
                    fileGotByte = (byte)fileStreamNew2.ReadByte();
                    if (myByteArray[0] == fileGotByte)
                    {
                        fileGotByte = (byte)fileStreamNew2.ReadByte();
                        if (myByteArray[1] == fileGotByte)
                        {
                            fileGotByte = (byte)fileStreamNew2.ReadByte();
                            if (myByteArray[2] == fileGotByte)
                            {
                                fileGotByte = (byte)fileStreamNew2.ReadByte();
                                if (myByteArray[3] == fileGotByte)
                                {
                                    fileStreamNew2.Position = positionInt;
                                    fileStreamNew2.Write(myByteArray2);
                                }
                            }
                        }
                    }
                }
                fileStreamNew2.Dispose();
                fileStreamNew2.Close();
                finishedFiles++;
                Console.Write("\r{0}/{1}", finishedFiles, shuffledSpecialFights.Length);
            }
            if (userInputInt[2] == 1)
            {
                using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "seed.txt"))
                {
                    Console.WriteLine("\nWriting seed to file...");
                    writer.WriteLine("Seed: " + userInputInt[1]);
                    writer.WriteLine("Encounter ------> Replaced Encounter");
                    for (int i = 0; i < vanillaEverythingFights.Length; i++)
                    {
                        writer.WriteLine(vanillaSpecialFights[i] + " ------> " + shuffledSpecialFights[i]);
                    }
                }
            }
            break;
        case 3:             //3. Shuffle Monster Arena(everything)
            //shuffledCreatureFights
            string[] shuffledCreatureFights = new string[vanillaCreatureFights.Length];    //5. Anything Goes(limited to what can be shuffled)
            for (int i = 0; i < vanillaCreatureFights.Length; i++)
            {
                shuffledCreatureFights[i] = vanillaCreatureFights[i];
            }
            for (int i = 0; i < shuffledCreatureFights.Length; i++)
            {
                int r = rand.Next(i, shuffledCreatureFights.Length);
                (shuffledCreatureFights[r], shuffledCreatureFights[i]) = (shuffledCreatureFights[i], shuffledCreatureFights[r]);
            }
            string[] shuffledWaterFights3 = new string[vanillaWaterFights.Length];
            for (int i = 0; i < vanillaWaterFights.Length; i++)
            {
                shuffledWaterFights3[i] = vanillaWaterFights[i];
            }
            for (int loopy = 0; loopy < 10; loopy++)
            {
                for (int i = 0; i < shuffledWaterFights3.Length; i++)
                {
                    int r = rand.Next(i, shuffledWaterFights3.Length);
                    (shuffledWaterFights3[r], shuffledWaterFights3[i]) = (shuffledWaterFights3[i], shuffledWaterFights3[r]);
                }
            }
            FileStream fileStreamOriginal3;
            FileStream fileStreamNew3;
            for (int i = 0; i < shuffledCreatureFights.Length; i++)
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledCreatureFights[i] + "\\"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledCreatureFights[i] + "\\");
                }
                fileStreamOriginal3 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Input\\" + baseFolderPath + "\\" + vanillaCreatureFights[i] + "\\" + vanillaCreatureFights[i] + ".bin", FileMode.Open, FileAccess.Read);
                fileStreamNew3 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledCreatureFights[i] + "\\" + shuffledCreatureFights[i] + ".bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fileStreamOriginal3.CopyTo(fileStreamNew3);
                fileStreamOriginal3.Dispose();
                fileStreamOriginal3.Close();
                foreachBuffer = 0;
                for (int thisLoop = 0; thisLoop < myByteArray.Length; thisLoop++)
                {
                    myByteArray[thisLoop] = 0x00;
                    myByteArray2[thisLoop] = 0x00;
                }
                foreach (char filenameCharacter in vanillaCreatureFights[i])
                {
                    myByteArray[foreachBuffer] = (byte)filenameCharacter;
                    foreachBuffer++;
                }
                foreachBuffer = 0;
                foreach (char filenameCharacter in shuffledCreatureFights[i])
                {
                    myByteArray2[foreachBuffer] = (byte)filenameCharacter;
                    foreachBuffer++;
                }
                if (myByteArray[9] <= 0xFF && myByteArray[9] > 0x00)
                {

                }
                else
                {
                    myByteArray[9] = 0x00;
                }
                if (myByteArray2[9] <= 0xFF && myByteArray2[9] > 0x00)
                {

                }
                else
                {
                    myByteArray2[9] = 0x00;
                }
                for (int positionInt = 0; positionInt < fileStreamNew3.Length - myByteArray.Length + 1; positionInt++)
                {
                    fileStreamNew3.Position = positionInt;
                    fileGotByte = (byte)fileStreamNew3.ReadByte();
                    if (myByteArray[0] == fileGotByte)
                    {
                        fileGotByte = (byte)fileStreamNew3.ReadByte();
                        if (myByteArray[1] == fileGotByte)
                        {
                            fileGotByte = (byte)fileStreamNew3.ReadByte();
                            if (myByteArray[2] == fileGotByte)
                            {
                                fileGotByte = (byte)fileStreamNew3.ReadByte();
                                if (myByteArray[3] == fileGotByte)
                                {
                                    fileStreamNew3.Position = positionInt;
                                    fileStreamNew3.Write(myByteArray2);
                                }
                            }
                        }
                    }
                }
                fileStreamNew3.Dispose();
                fileStreamNew3.Close();
                finishedFiles++;
                Console.Write("\r{0}/{1}", finishedFiles, shuffledCreatureFights.Length);
            }
            if (userInputInt[2] == 1)
            {
                using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "seed.txt"))
                {
                    Console.WriteLine("\nWriting seed to file...");
                    writer.WriteLine("Seed: " + userInputInt[1]);
                    writer.WriteLine("Encounter ------> Replaced Encounter");
                    for (int i = 0; i < vanillaEverythingFights.Length; i++)
                    {
                        writer.WriteLine(vanillaCreatureFights[i] + " ------> " + shuffledCreatureFights[i]);
                    }
                }
            }
            break;
        case 4:             //4. Shuffle Dark Aeons
            //shuffledDarkAeonFights
            string[] shuffledDarkAeonFights = new string[vanillaDarkAeonFights.Length];    //5. Anything Goes(limited to what can be shuffled)
            for (int i = 0; i < vanillaDarkAeonFights.Length; i++)
            {
                shuffledDarkAeonFights[i] = vanillaDarkAeonFights[i];
            }
            for (int i = 0; i < shuffledDarkAeonFights.Length; i++)
            {
                int r = rand.Next(i, shuffledDarkAeonFights.Length);
                (shuffledDarkAeonFights[r], shuffledDarkAeonFights[i]) = (shuffledDarkAeonFights[i], shuffledDarkAeonFights[r]);
            }
            FileStream fileStreamOriginal4;
            FileStream fileStreamNew4;
            for (int i = 0; i < shuffledDarkAeonFights.Length; i++)
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledDarkAeonFights[i] + "\\"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledDarkAeonFights[i] + "\\");
                }
                fileStreamOriginal4 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Input\\" + baseFolderPath + "\\" + vanillaDarkAeonFights[i] + "\\" + vanillaDarkAeonFights[i] + ".bin", FileMode.Open, FileAccess.Read);
                fileStreamNew4 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledDarkAeonFights[i] + "\\" + shuffledDarkAeonFights[i] + ".bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fileStreamOriginal4.CopyTo(fileStreamNew4);
                fileStreamOriginal4.Dispose();
                fileStreamOriginal4.Close();
                //
                foreachBuffer = 0;
                for (int thisLoop = 0; thisLoop < myByteArray.Length; thisLoop++)
                {
                    myByteArray[thisLoop] = 0x00;
                    myByteArray2[thisLoop] = 0x00;
                }
                foreach (char filenameCharacter in vanillaDarkAeonFights[i])
                {
                    myByteArray[foreachBuffer] = (byte)filenameCharacter;
                    foreachBuffer++;
                }
                foreachBuffer = 0;
                foreach (char filenameCharacter in shuffledDarkAeonFights[i])
                {
                    myByteArray2[foreachBuffer] = (byte)filenameCharacter;
                    foreachBuffer++;
                }
                if (myByteArray[9] <= 0xFF && myByteArray[9] > 0x00)
                {

                }
                else
                {
                    myByteArray[9] = 0x00;
                }
                if (myByteArray2[9] <= 0xFF && myByteArray2[9] > 0x00)
                {

                }
                else
                {
                    myByteArray2[9] = 0x00;
                }
                for (int positionInt = 0; positionInt < fileStreamNew4.Length - myByteArray.Length + 1; positionInt++)
                {
                    fileStreamNew4.Position = positionInt;
                    fileGotByte = (byte)fileStreamNew4.ReadByte();
                    if (myByteArray[0] == fileGotByte)
                    {
                        fileGotByte = (byte)fileStreamNew4.ReadByte();
                        if (myByteArray[1] == fileGotByte)
                        {
                            fileGotByte = (byte)fileStreamNew4.ReadByte();
                            if (myByteArray[2] == fileGotByte)
                            {
                                fileGotByte = (byte)fileStreamNew4.ReadByte();
                                if (myByteArray[3] == fileGotByte)
                                {
                                    fileStreamNew4.Position = positionInt;
                                    fileStreamNew4.Write(myByteArray2);
                                }
                            }
                        }
                    }
                }
                //
                fileStreamNew4.Dispose();
                fileStreamNew4.Close();
                finishedFiles++;
                Console.Write("\r{0}/{1}", finishedFiles, shuffledDarkAeonFights.Length);
            }
            if (userInputInt[2] == 1)
            {
                using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "seed.txt"))
                {
                    Console.WriteLine("\nWriting seed to file...");
                    writer.WriteLine("Seed: " + userInputInt[1]);
                    writer.WriteLine("Encounter ------> Replaced Encounter");
                    for (int i = 0; i < vanillaEverythingFights.Length; i++)
                    {
                        writer.WriteLine(vanillaDarkAeonFights[i] + " ------> " + shuffledDarkAeonFights[i]);
                    }
                }
            }
            break;
        case 5:             //5. Anything Goes(limited to what can be shuffled)
        EVERYTHING:
            //shuffledEverythingFights
            string[] shuffledEverythingFights = new string[vanillaEverythingFights.Length];
            for (int i = 0; i < vanillaEverythingFights.Length; i++)
            {
                shuffledEverythingFights[i] = vanillaEverythingFights[i];
            }
            for (int i = 0; i < shuffledEverythingFights.Length; i++)
            {
                int r = rand.Next(i, shuffledEverythingFights.Length);
                (shuffledEverythingFights[r], shuffledEverythingFights[i]) = (shuffledEverythingFights[i], shuffledEverythingFights[r]);
            }
            string[] shuffledWaterFights5 = new string[vanillaWaterFights.Length];
            for (int i = 0; i < vanillaWaterFights.Length; i++)
            {
                shuffledWaterFights5[i] = vanillaWaterFights[i];
            }
            for (int loopy = 0; loopy < 10; loopy++)
            {
                for (int i = 0; i < shuffledWaterFights5.Length; i++)
                {
                    int r = rand.Next(i, shuffledWaterFights5.Length);
                    (shuffledWaterFights5[r], shuffledWaterFights5[i]) = (shuffledWaterFights5[i], shuffledWaterFights5[r]);
                }
            }
            vanillaEverythingFights = vanillaEverythingFights.Concat(vanillaWaterFights).ToArray();
            shuffledEverythingFights = shuffledEverythingFights.Concat(shuffledWaterFights5).ToArray();
            FileStream fileStreamOriginal5;
            FileStream fileStreamNew5;

            for (int i = 0; i < shuffledEverythingFights.Length; i++)
            {
                if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledEverythingFights[i] + "\\"))
                {
                    Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledEverythingFights[i] + "\\");
                }
                fileStreamOriginal5 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Input\\" + baseFolderPath + "\\" + vanillaEverythingFights[i] + "\\" + vanillaEverythingFights[i] + ".bin", FileMode.Open, FileAccess.Read);
                fileStreamNew5 = new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Output\\" + baseFolderPath + "\\" + shuffledEverythingFights[i] + "\\" + shuffledEverythingFights[i] + ".bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                fileStreamOriginal5.CopyTo(fileStreamNew5);
                fileStreamOriginal5.Dispose();
                fileStreamOriginal5.Close();
                foreachBuffer = 0;
                for(int thisLoop = 0; thisLoop < myByteArray.Length; thisLoop++)
                {
                    myByteArray[thisLoop] = 0x00;
                    myByteArray2[thisLoop] = 0x00;
                }
                foreach (char filenameCharacter in vanillaEverythingFights[i])
                {
                    myByteArray[foreachBuffer] = (byte)filenameCharacter;
                    foreachBuffer++;
                }
                foreachBuffer = 0;
                foreach (char filenameCharacter in shuffledEverythingFights[i])
                {
                    myByteArray2[foreachBuffer] = (byte)filenameCharacter;
                    foreachBuffer++;
                }
                if (myByteArray[9] <= 0xFF && myByteArray[9] > 0x00)
                {

                }
                else
                {
                    myByteArray[9] = 0x00;
                }
                if (myByteArray2[9] <= 0xFF && myByteArray2[9] > 0x00)
                {

                }
                else
                {
                    myByteArray2[9] = 0x00;
                }
                for (int positionInt = 0; positionInt < fileStreamNew5.Length - myByteArray.Length + 1; positionInt++)
                {
                    fileStreamNew5.Position = positionInt;
                    fileGotByte = (byte)fileStreamNew5.ReadByte();
                    if (myByteArray[0] == fileGotByte)
                    {
                        fileGotByte = (byte)fileStreamNew5.ReadByte();
                        if (myByteArray[1] == fileGotByte)
                        {
                            fileGotByte = (byte)fileStreamNew5.ReadByte();
                            if (myByteArray[2] == fileGotByte)
                            {
                                fileGotByte = (byte)fileStreamNew5.ReadByte();
                                if (myByteArray[3] == fileGotByte)
                                {
                                    fileStreamNew5.Position = positionInt;
                                    fileStreamNew5.Write(myByteArray2);
                                }
                            }
                        }
                    }
                }
                fileStreamNew5.Dispose();
                fileStreamNew5.Close();
                finishedFiles++;
                Console.Write("\r{0}/{1}", finishedFiles, shuffledEverythingFights.Length);
            }
            if (userInputInt[2] == 1)
            {
                using (StreamWriter writer = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory + "seed.txt"))
                {
                    Console.WriteLine("\nWriting seed to file...");
                    writer.WriteLine("Seed: " + userInputInt[1]);
                    writer.WriteLine("Encounter ------> Replaced Encounter");
                    for (int i = 0; i < vanillaEverythingFights.Length; i++)
                    {
                        writer.WriteLine(vanillaEverythingFights[i] + " ------> " + shuffledEverythingFights[i]);
                    }
                }
            }
            break;
        default:            //Default, which is shuffleeverything. A simple goto case 5.
            goto EVERYTHING;
    }
    phat = 5;
}

Console.WriteLine("\nRandomization complete!\n\nOption Selected: " + userInput[0] + "\nSeed: " + userInputInt[1] + "\nOutput: " + AppDomain.CurrentDomain.BaseDirectory + "Output\\\n\nPress any key to exit.");
Console.ReadKey();