using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Diagnostics;

namespace euler
{
    class problem_059
    {
        List<string> commonWords = new List<string>
        {
            "the",
            "have"
        };

        string makeCipher(byte a, byte b, byte c)
        {
            string key = null;
            key = Convert.ToChar(a).ToString() + Convert.ToChar(b).ToString() + Convert.ToChar(c).ToString();

            return key;
        }

        public problem_059()
        {
            string f = @"..\..\problem_059_cipher.in";
            string cipher = null;
            string decode = null;
            List<string> decodeList = new List<string>();
            string line = null;
            byte[] bytechar;
            int j = 0;
            int sum = 0;
            bool halt = false;


            Stopwatch sw = new Stopwatch();
            sw.Start();

            using (StreamReader r = new StreamReader(f))
            {
                line = r.ReadLine();
            }
            bytechar = line.Split(',').Select(byte.Parse).ToArray();

            for (byte a = 97; a < 123; a++)
                for (byte b = 97; b < 123; b++)
                    for (byte c = 97; c < 123; c++)
                    {
                        cipher = makeCipher(a, b, c);
                        decode = null;
                        decodeList.Clear();

                        for (int i = 0; i < bytechar.Length; i++)
                        {
                            byte tempy = (byte)(bytechar[i] ^ (byte)cipher[j]);
                            if (tempy < 32 || tempy > 127)
                            {
                                halt = true;
                                break;
                            }
                            decode += (char)(tempy);

                            j++;
                            if (j == 3)
                                j = 0;
                        }
                        if (halt)
                        {
                            halt = false;
                            break;
                        }
                        decodeList = decode.Split(' ').ToList();

                        for (int k = 0; k < commonWords.Count; k++)
                        {
                            if (decodeList.Contains(commonWords[k]) && decodeList.Count > 200)
                            {
                                for (int l = 0; l < decode.Length; l++)
                                {
                                    sum += (byte)decode[l];
                                }
                                break;
                            }
                        }
                    }


            Console.WriteLine("Problem 059");
            Console.WriteLine(sum);
            sw.Stop();
            long ts = sw.ElapsedMilliseconds;
            Console.WriteLine("Time elapsed: {0} ms", ts);
            Console.WriteLine(Utils.sep);
        }
    }
}
