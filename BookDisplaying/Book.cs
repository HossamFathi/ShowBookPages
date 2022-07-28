using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDisplaying
{
    public class Book
    {
        private List<Page> Pages { get; set; } // source Pages
        private Stack<Page> NextPages = new Stack<Page>();
        private Stack<Page> PrivuesPages = new Stack<Page>();
        public Book()
        {
            setData();
            Pages.Reverse();
            Pages.ForEach(pa => NextPages.Push(pa));
        }
        private void setData()
        {
            Pages = new List<Page>()
            {
                 new Page()  ,
                 new Page()  ,
                 new Page()
            };
            int i = 1;
            Pages.ForEach(p =>
            {
                p.setContent("page Number " + i++ + "  " + p.GetDefaultContent());
                p.setcBookName("cagel Book");
            });

        }
        private void GoNext()
        {
            
            Page page = null;
            if (NextPages.TryPop(out page))
            {
                PrivuesPages.Push(page);
                Show(page);
            }
            else
            {
                Console.WriteLine("------------------No Pages Go To Back----------------------");
                GoPrivues();
            };
        }
        private bool HaveNext()
        {
            return NextPages.Count > 0;
        }
        private void GoPrivues()
        {
            Page page = null;
            if (PrivuesPages.TryPop(out page))
            {
                NextPages.Push(page);
                Show(page);
            }
            else 
            {
                Console.WriteLine("------------------No Pages Go To Next----------------------");
                GoNext();
             };
            
        }
        private bool HavePrivues()
        {
            return PrivuesPages.Count > 0;
        }
     
        public void StartWatching()
        {
            GoNext();
        }
        public void Go(string direction)
        {
            if (!string.IsNullOrEmpty(direction))
            {
                if (direction.Substring(0, 1).ToString().ToUpper().Equals(setting.Next.ToString()))
                {
                    Console.Clear();
                    GoNext();
                }
                else if (direction.Substring(0, 1).ToString().ToUpper().Equals(setting.Back.ToString()))
                {
                    Console.Clear();
                    GoPrivues();
                }
                else if (direction.Substring(0, 1).ToString().ToUpper().Equals(setting.Close.ToString()))
                    System.Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("please Enter (N , B , C) only");
            }
        }
        private void Show(Page page)
        {
            if(page is not null)
                page.Show();
            if (HavePrivues()) {
                Console.Write("(B) For Back"); 
           }
            if (HaveNext()) {
                Console.Write("\t \t \t \t\t\t\t\t (N) For Next"); 
           }
            Console.WriteLine();
        }
    }
}
