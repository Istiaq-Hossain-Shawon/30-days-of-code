using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int NumberOfString=Convert.ToInt32(Console.ReadLine());;
        
        
        string evenString="";
        string oddString="";
        for(int j=1;j<=NumberOfString;j++) {
            string S=Console.ReadLine();
            int len=S.Length;
            for(int i=0;i<=len-1;i++){
                if(i%2==0){
                    evenString=evenString+S[i];
                }else{
                    oddString=oddString+S[i];
                }
            }
            Console.WriteLine(evenString+" "+oddString);
            evenString="";
            oddString="";
        }
        
        
    }
}

