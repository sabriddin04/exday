List<int> list = new List<int>() {1, 0, 5, -4, 5, 10 ,-80, 24, 0, -4, 100, 24, 45, 6, -1};

int max=list.Max();
System.Console.WriteLine("max="+max);
System.Console.WriteLine("-------------------------------");
int cnt=0;
List<int> newlist = new List<int>();
for(int i=0;i<list.Count;i++){
cnt=0;
for(int j=0;j<list.Count;j++){
    if(i!=j && list[i]==list[j]){
        cnt++;
    }
   
} if(cnt==0){
        newlist.Add(list[i]);

    }
}
foreach (var item in newlist)
{
    System.Console.Write(item+" ");
}
System.Console.WriteLine("");
System.Console.WriteLine("-------------------------------");
list.Sort();
foreach (var item in list)
{
    System.Console.Write(item+" ");
}

for (int i = 0; i < list.Count; i++)
{
    if(list[i]<0){
        list[i]=0;
    }
}
System.Console.WriteLine("");
System.Console.WriteLine("-------------------------------");
foreach (var item in list)
{
    System.Console.Write(item+" ");
}