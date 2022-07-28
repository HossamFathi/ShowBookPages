using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookDisplaying
{
    public class Page
    {
        private string BookName { get; set; }
        private string Content { get; set; }

        public string GetDefaultContent() {

            return "To make pulp from wood, a chemical pulping process separates lignin from cellulose fibre. A cooking liquor is used to dissolve the lignin, which is then washed from the cellulose; this preserves the length of the cellulose fibres. Paper made from chemical pulps are also known as wood-free papers (not to be confused with tree-free paper); this is because they do not contain lignin, which deteriorates over time. The pulp can also be bleached to produce white paper, but this consumes 5% of the fibres. Chemical pulping processes are not used to make paper made from cotton, which is already 90% cellulose.The microscopic structure of paper: Micrograph of paper autofluorescing under ultraviolet illumination.The individual fibres in this sample are around 10 µm in diameter.There are three main chemical pulping processes: the sulfite process dates back to the 1840s and was the dominant method before the second world war.The kraft process, invented in the 1870s and first used in the 1890s, is now the most commonly practised strategy; one of its advantages is the chemical reaction with lignin produces heat, which can be used to run a generator. Most pulping operations using the kraft process are net contributors to the electricity grid or use the electricity to run an adjacent paper mill. Another advantage is that this process recovers and reuses all inorganic chemical reagents. Soda pulping is another specialty process used to pulp straws, bagasse and hardwoods with high silicate content";
        
        }
        public void setContent(string Content)
        {
            this.Content = Content;
        }
        public void setcBookName(string BookName)
        {
            this.BookName = BookName;
        }
        public void Show()
        {
            this.ToString();
        }
        public override string ToString()
        {
            Console.WriteLine("Book Name : " + BookName);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            Console.WriteLine(Content);
            Console.WriteLine("-----------------------------------------------------------------------------------------");
            return "";     
        }
    }
}
