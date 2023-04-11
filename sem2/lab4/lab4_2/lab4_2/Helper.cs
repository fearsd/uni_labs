using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2
{
    public class Helper
    {
        private string prefix;
        public DataElement[] elems;
        public int elemNum = 0;
        public int elemSum = 0;
        //public float elemWidth;
        //public int[] axisSizes;
        public float elemCoef;
        public string readFromFile = "1.txt";
        public string writeToFile = "2.txt";
        public Helper()
        {
            //this.axisSizes = axisSizes;
            //heightCoef = axisSizes[1] / 100;

            //prefix = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            prefix = @"..\..\..\";
        }
        public void BuildGraphics()
        {
            GenerateElems();

        }
        public void BuildGraphicsFromFile(string readFromFile)
        {
            // pass an empty string to use default file
            if (readFromFile == "") readFromFile = Path.Combine(prefix, this.readFromFile);
            elemNum = File.ReadLines(readFromFile).Count();
            elems = new DataElement[elemNum];
            elemSum = 0;
            var lines = File.ReadLines(readFromFile).ToArray();
            for (int i = 0; i < elemNum; i++)
            {
                int[] elemData = SerializeLine(lines[i]);
                elems[i] = new DataElement(elemData[0], elemData[1], elemData[2], elemData[3]);
                elemSum += elemData[0];
            }
            elemCoef = 360F / (float)elemSum;
        }
        public void WriteCurrentDataToFile(string writeToFile)
        {
            // pass an empty string to use default file
            if (writeToFile == "") writeToFile = Path.Combine(prefix, this.writeToFile);
            File.WriteAllText(writeToFile, "");
            string[] lines = new string[elemNum];
            for (int i = 0; i < elemNum; i++)
            {
                lines[i] = DeserializeElem(elems[i]);
            }
            File.AppendAllLines(writeToFile, lines);

        }
        private void GenerateElems()
        {
            Random rnd = new Random();
            elemNum = rnd.Next(2, 8);
            elems = new DataElement[elemNum];
            elemSum = 0;
            for (int i = 0; i < elemNum; i++)
            {
                int[] elemData = GenerateElemData();
                elems[i] = new DataElement(elemData[0], elemData[1], elemData[2], elemData[3]);
                elemSum += elemData[0];
            }
            elemCoef = 360F / (float)elemSum;
        }
        private int[] GenerateElemData()
        {
            Random rnd = new Random();
            int weight = rnd.Next(0, 100);
            int red = rnd.Next(0, 256);
            int green = rnd.Next(0, 256);
            int blue = rnd.Next(0, 256);

            return new int[] { weight, red, green, blue };
        }
        private int[] SerializeLine(string line)
        {
            string[] rawData = line.Split(':');
            int[] elemData = rawData.Select(d => int.Parse(d)).ToArray();
            return elemData;
        }
        private string DeserializeElem(DataElement elem)
        {
            return $"{elem.weight}:{elem.red}:{elem.green}:{elem.blue}";
        }
    }
}
