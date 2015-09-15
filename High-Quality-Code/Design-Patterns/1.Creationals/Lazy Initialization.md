# Lazy initialization Pattern

##          

 *                                                      ,                                                           .                                                          'Lazy initialization pattern',                                                                   .
 
##    

 *                                          ,                           

##           

*        1:

                       .                    ,                                                    .                                  ,        ,        ,       ,           . .             'Entity Framework'                                           'Student'                                                                           .                                                           .                                                                                                                 ,                                 ,                                               .                  ,     'Entity framework'                                        :D                 ,                                 property-  (              ,                               -          '       ', '       ')                      'virtual'                                    'EF'            'proxy'        ,                                      (Student)                       ,                                           ,                'currentStudent.grades'              'get'-a          .
 

##                  

* Entity Framework
* Singleton design pattern
* IQueryable           -                                                      ,                                  RAM                               (lazy loading)


##              

```
public class Customer
{
    public int CustomerID { get; set; }
    public string Name { get; set; }
    private IEnumerable<Order> _orders;

    public IEnumerable<Order> Orders
    {
        get
        {
            if (_orders == null)
            {
                _orders = OrdersDatabase.GetOrders(CustomerID);
            }
            return _orders;
        }
    }

    // Constructor
    public Customer(int id, string name)
    {
        CustomerID = id;
        Name = name;
    }
} 
  ```

##            
*                            .
*                                                        

##              
*         ,       

##         

*                           .                                ,                                          .