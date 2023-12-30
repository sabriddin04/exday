class Person
{
    string name;
    string address;


   public Person(string name,string address)
   {
    this.name=name;
    this.address=address;
   }
     public string GetName(){
    return name;
   }
     public string GetAddress(){
    return address;
   }
   public void SetAddress(string address){
    this.address=address;

   }



   public virtual  string ToString(){

    return $"Person[ name={name}, address={address}]";

   }




}