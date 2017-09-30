namespace gildedRoseKata{
    public class Backstage : OtherItems{
        
        private string name;
        private int sellIn;
        private int quality;
        public Backstage(string name,int sellIng, int quality){
            this.name = name;
            this.quality = quality;
            this.sellIn = sellIng;
        }
        
        public string Name(){
            return "Backstage passes to a TAFKAL80ETC concert";
        }

        public int SellIn(){
            throw new System.NotImplementedException();
        }

        public int Quality(){
            throw new System.NotImplementedException();
        }
    }
}