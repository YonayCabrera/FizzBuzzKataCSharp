using System.Collections.Generic;
using NUnit.Framework;


namespace gildedRoseKata
{
    [TestFixture]
    public class GildenRoseShould{
        private List<Item> Items;
        private GildedRoseKata gildedRoseKata;
        [SetUp]
        public void SetUp(){
            Items = new List<Item>();
            gildedRoseKata = new GildedRoseKata(Items);
        }
        [Test]
        public void Legendary_item_dont_decrement_quality(){
            Item sulfuras = new Item(){ Name = "Sulfuras, Hand of Ragnaros",Quality = 80};
            Items.Add(sulfuras); 
            gildedRoseKata.UpdateQuality();
            Assert.AreEqual(sulfuras.Quality,80 );
        }

        [Test]
        public void Quality_is_never_more_than_fifty(){
            Item aged = new Item(){ Name = "Aged Brie", Quality = 50 ,SellIn = 12};
            Items.Add(aged);
            gildedRoseKata.UpdateQuality();
            Assert.AreEqual(aged.Quality,50);
        }

        [Test]
        public void Quality_of_backstage_increment_on_three(){
            Item backstage = new Item(){ Name = "Backstage passes to a TAFKAL80ETC concert" ,
                Quality = 10 ,SellIn = 1};
            Items.Add(backstage);
            gildedRoseKata.UpdateQuality();
            Assert.AreEqual(backstage.Quality,13);
        }
        
        [Test]
        public void Quality_of_backstage_increment_on_two(){
            Item backstage = new Item(){ Name = "Backstage passes to a TAFKAL80ETC concert" ,
                Quality = 10 ,SellIn = 8};
            Items.Add(backstage);
            gildedRoseKata.UpdateQuality();
            Assert.AreEqual(backstage.Quality,12);
        }

        [Test]
        public void Increases_in_Quality_the_older_if_is_Aged(){
            Item aged = new Item(){ Name = "Aged Brie", Quality = 2 ,SellIn = -1};
            Items.Add(aged);
            gildedRoseKata.UpdateQuality();
            Assert.AreEqual(aged.Quality,4);
        }
        
        [Test]
        public void Quality_drops_to_0_after_the_concert_if_is_backstage(){
            Item backstage = new Item(){ Name = "Backstage passes to a TAFKAL80ETC concert" ,
                Quality = 50 ,SellIn = -1};
            Items.Add(backstage);
            gildedRoseKata.UpdateQuality();
            Assert.AreEqual(backstage.Quality,0);
        }
        
        [Test]
        public void Quality_degrades_twice_after_the_concert_if_is_normal_item(){
            Item item = new Item(){ Name = "item" ,
                Quality = 30 ,SellIn = -5};
            Items.Add(item);
            gildedRoseKata.UpdateQuality();
            Assert.AreEqual(item.Quality,28);
        }
        
        [Test]
        public void Quality_is_never_negative(){
            Item item = new Item(){ Name = "item" ,
                Quality = 1 ,SellIn = -5};
            Items.Add(item);
            gildedRoseKata.UpdateQuality();
            Assert.AreEqual(item.Quality,0);
        }
        
        [Test]
        public void Quality_of_Aged_increases_when_is_more_old(){
            Item aged = new Item(){ Name = "Aged Brie", Quality = 2 ,SellIn = 50};
            Items.Add(aged);
            gildedRoseKata.UpdateQuality();
            Assert.AreEqual(aged.Quality,3);
        }
    }
}
