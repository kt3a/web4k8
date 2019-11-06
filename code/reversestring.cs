class MainClass {
  public static void Main (string[] args) {
    string str;
    int l=0;

    Console.WriteLine("Input the string: ");
    str = Console.ReadLine();
	  
    l = str.Length - 1;
	 Console.WriteLine("The characters of the string in reverse are:");

    while (l >= 0){
      Console.Write("{0} ", str[l]);
      l--;
    }

    // for(l; l<= 0; l--){
    //   Console.Write(str[l]);
    // }
  }
}