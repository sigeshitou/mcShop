namespace mcShopServer.Serialized{
    public class ItemParser{
        
        public long ItemId { get; set; }
        
        public string McItemId {get;set;}
        public string McItemName { get; set; }
        public long ItemQuantity {get;set;}
        public long ItemPrice{get;set;}
        public long UserId {get;set;}
        
    }
}