Console.WriteLine("Введите число: ");
int q= Convert.ToInt32(Console.ReadLine()) ;

void Kub (int x){
int[] a={};
for (int i=1; i<=x;i=i+1){
   Console.Write(Convert.ToString(Math.Pow(i,3))+' ' );
}

}

Kub(q);
