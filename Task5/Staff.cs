class Staff:Person
{
    string school;
    double pay;

   public Staff(string name,string addres,string school,double pay):base(name,addres)
    {
        this.school=school;
        this.pay=pay;
    }

    public string GetSchool(){
        return school;
    }
    public void SetSchool(string school){
        this.school=school;
    }
     public double GetPay(){
        return pay;
    }
    public void SetPay(double pay){
        this.pay=pay;
    }

    public  string ToString()
    {
        return base.ToString()+"[ school="+school+" pay="+pay+"]";
    }

}