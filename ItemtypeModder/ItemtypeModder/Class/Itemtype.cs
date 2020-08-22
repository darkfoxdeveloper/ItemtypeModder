using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ItemtypeModder
{
    public class Itemtype
    {
        private byte[] key;
        public List<Item> Items;
        public string SourceFile;
        public string TargetFile;
        public string Separator = "@@";
        private bool OldItemtypeVersion = false;

        public void LoadItems()
        {
            string[] ItemsTxt = File.ReadAllLines(this.TargetFile);
            Items = new List<Item>();
            for (int i = 0; i < ItemsTxt.Length; i++)
            {
                if (i == 0)
                {
                    OldItemtypeVersion = ItemsTxt[i].Contains("Amount=");
                }
                if (!ItemsTxt[i].Contains("Amount=") && ItemsTxt[i].Length > 0)
                {
                    Items.Add(new Item(ItemsTxt[i], true));
                }
            }
        }

        public void SaveItems()
        {
            List<string> lines = new List<string>();
            for (int i = 0; i < this.Items.Count; i++)
            {
                if (Separator.Length > 0)
                {
                    this.Items[i].Export(Separator);
                } else
                {
                    this.Items[i].Export();
                }
                lines.Add(this.Items[i].ToString());
            }
            if (OldItemtypeVersion)
            {
                lines.Insert(0, "Amount=" + lines.Count);
            }
            File.WriteAllLines(this.TargetFile, lines);
            this.Encrypt();
        }

        public Itemtype(string SourceFile)
        {
            this.SourceFile = SourceFile;
            int seed;
            if (!int.TryParse("2537", NumberStyles.HexNumber, null, out seed))
            {
                return;
            }
            key = new byte[0x80];
            MSRandom r = new MSRandom(seed);
            for (int i = 0; i < key.Length; i++)
            {
                key[i] = (byte)(r.Next() % 0x100);
            }
        }
       
        public void Decrypt()
        {
            byte[] b = File.ReadAllBytes(SourceFile);
            for (int i = 0; i < b.Length; i++)
            {
                int num = b[i] ^ key[i % 0x80];
                int bits = i % 8;
                b[i] = (byte)((num << (8 - bits)) + (num >> bits));
            }
            this.TargetFile = Path.GetDirectoryName(SourceFile) + "/" + Path.GetFileNameWithoutExtension(SourceFile) + ".txt";
            File.WriteAllBytes(this.TargetFile, b);
        }

        public void Encrypt()
        {
            byte[] b = File.ReadAllBytes(this.TargetFile);
            for (int i = 0; i < b.Length; i++)
            {
                int bits = i % 8;
                int num = (byte)((b[i] >> (8 - bits)) + (b[i] << bits));
                b[i] = (byte)(num ^ key[i % 0x80]);
            }
            File.WriteAllBytes(SourceFile, b);
        }

        public class MSRandom
        {
            public long Seed;
            public MSRandom(int seed)
            {
                Seed = seed;
            }
            public int Next()
            {
                return (int)(((Seed = Seed * 214013L + 2531011L) >> 16) & 0x7fff);
            }
        }
    }
}
