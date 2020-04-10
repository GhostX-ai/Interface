using System;

namespace DocWorker
{
    class Program
    {
        static void Main(string[] args)
        {
            string passpro = "MACBOOK_PRO2015".ToLower();
            string passex = "MACBOOK_PRO2016".ToLower();
            Console.WriteLine("Enter pass:");
            string inpass = Console.ReadLine().ToLower();
            if (inpass == passpro)
            {
                ProAccess();
            }
            else if (inpass == passex)
            {
                ExAccess();
            }
            else
            {
                BaseAccess();
            }
            Console.Clear();
            Player();
            Console.Clear();
            Recorder();
            Console.ReadKey();
        }
        static void Player()
        {
            bool chk = true;
            PlayMusic pl = new PlayMusic();
            while (chk)
            {
                Console.WriteLine("You are in music player");
                Console.WriteLine("1 for play\n2 for pause\n 3 for stop\n 4 for exit");
                int chs = int.Parse(Console.ReadLine());
                switch (chs)
                {
                    case 1:
                        pl.Play(); break;
                    case 2:
                        pl.Pause(); break;
                    case 3:
                        pl.Stop(); break;
                    case 4:
                        chk = false; break;
                }
            }
        }
        static void Recorder()
        {
            bool chk = true;
            RecordMusic rd = new RecordMusic();
            while (chk)
            {
                Console.WriteLine("You are in music recorder");
                Console.WriteLine("1 for record\n2 for pause\n 3 for stop\n 4 for exit");
                int chs = int.Parse(Console.ReadLine());
                switch (chs)
                {
                    case 1:
                        rd.Record(); break;
                    case 2:
                        rd.Pause(); break;
                    case 3:
                        rd.Stop(); break;
                    case 4:
                        chk = false; break;
                }
            }
        }
        static void BaseAccess()
        {
            bool chk = true;
            DocumentWorker dw = new DocumentWorker();
            while (chk)
            {
                Console.Clear();
                Console.WriteLine("You are in Base access");
                Console.WriteLine("1 for open file\n2 for edit\n3 for save\n4 for exit");
                int chs = int.Parse(Console.ReadLine());
                switch (chs)
                {
                    case 1:
                        {
                            dw.OpenDocument();
                        }
                        break;
                    case 2:
                        {
                            dw.EditDocument();
                        }
                        break;
                    case 3:
                        {
                            dw.SaveDocument();
                        }
                        break;
                    case 4:
                        {
                            chk = false;
                        }
                        break;
                }
            }
        }
        static void ProAccess()
        {
            bool chk = true;
            DocumentWorker pdw = new ProDocumentWorker();
            while (chk)
            {
                Console.Clear();
                Console.WriteLine("You are in Pro access");
                Console.WriteLine("1 for open file\n2 for edit\n3 for save\n4 for exit");
                int chs = int.Parse(Console.ReadLine());
                switch (chs)
                {
                    case 1:
                        {
                            pdw.OpenDocument();
                        }
                        break;
                    case 2:
                        {
                            pdw.EditDocument();
                        }
                        break;
                    case 3:
                        {
                            pdw.SaveDocument();
                        }
                        break;
                    case 4:
                        {
                            chk = false;
                        }
                        break;
                }
            }
        }
        static void ExAccess()
        {
            bool chk = true;
            DocumentWorker edw = new ExpertDocumentWorker();
            while (chk)
            {
                Console.Clear();
                Console.WriteLine("You are in Base access");
                Console.WriteLine("1 for open file\n2 for edit\n3 for save\n4 for exit");
                int chs = int.Parse(Console.ReadLine());
                switch (chs)
                {
                    case 1:
                        {
                            edw.OpenDocument();
                        }
                        break;
                    case 2:
                        {
                            edw.EditDocument();
                        }
                        break;
                    case 3:
                        {
                            edw.SaveDocument();
                        }
                        break;
                    case 4:
                        {
                            chk = false;
                        }
                        break;
                }
            }
        }
    }
}
