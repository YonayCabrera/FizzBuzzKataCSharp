namespace gildedRoseKata{
    public class Sulfuras : OtherItems{

        private string name;
        private int sellIn;
        private int quality;
        public Sulfuras(string name,int sellIng, int quality){
            this.name = name;
            this.quality = quality;
            this.sellIn = sellIng;
        }

        public string Name(){
            return "Sulfuras, Hand of Ragnaros";
        }

        public int SellIn(){
            throw new System.NotImplementedException();
        }

        public int Quality(){
            throw new System.NotImplementedException();
        }
    }
}