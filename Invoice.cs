namespace InvoiceTest {
    public class Invoice{
         public  string name;

         public string description;

        public int quantity;

        public decimal price;
         public string Name
        {
            get
            { 
                return name;     
            }
            set 
            {
                name = value;
            }
        }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
            
             description = value;
                
               
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
            
             if(value < 0.0M)
                {
                 quantity = 0;
                } else {
                    quantity = value;

                }
                
           
               
            }
        }
   
     public decimal Price
        {
            get
            {
                return price;
            }
            set
            {
            
             price = value;
                
               
            }
        }
        
        
         


           public Invoice(string name, string description, int quantity, decimal price)
        { 
           Name = name;
           Description = description;
           Quantity = quantity;
           Price = price;
        }

        public decimal GetInvoiceAmount(){
          return Quantity * Price;
       }
    

    }
}









    