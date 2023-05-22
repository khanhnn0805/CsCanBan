

int[] a = new int[5];//Kết hợp khai báo phần tử và số lượng
//int[] b = new int[] { 5, 3, 9 };// khai báo bỏ qua số lượng tối đa trong mảng

//Check phần tử đầu tiên a[0]
//Check phần tử thứ 5 a[5]
//Check phần tử thứ 7 
int[] c = {1,2,3,4,5};
for (int i = 0; i < c.Length; i++) 
{ Console.Write(c[i] + " "); };

Console.WriteLine("Dung foreach");
foreach (int i in c)
{ Console.Write(i + " "); };

Console.ReadKey();