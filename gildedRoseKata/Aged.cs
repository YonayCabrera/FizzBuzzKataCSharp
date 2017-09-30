namespace gildedRoseKata{
    public class Aged : OtherItems{
        
        private string name;
        private int sellIn;
        private int quality;
        public Aged(string name,int sellIng, int quality){
            this.name = name;
            this.quality = quality;
            this.sellIn = sellIng;
        }
        
        public string Name(){
            return "Aged Brie";
        }

        public int SellIn(){
            throw new System.NotImplementedException();
        }

        public int Quality(){
            throw new System.NotImplementedException();
        }
    }
}