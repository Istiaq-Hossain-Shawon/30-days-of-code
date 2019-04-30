using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        int n= Convert.ToInt32(Console.ReadLine());
        Dictionary<string, string> dict = new Dictionary<string, string>();
        for(int i=0;i<n;i++){
            string input= Console.ReadLine();
            string[] items = input.Split(new[] {" "}, StringSplitOptions.None);
            for(int j=0;j<items.Length;j++){
                //Console.WriteLine(items[j]);
                if (!dict.ContainsKey(items[0])) { 
                    dict.Add(items[0],items[1]);
                }
                
            }
        }
        for(int i=0;i<n;i++){
            string input= Console.ReadLine();
            string data="";
            if (dict.ContainsKey(input)) { 
                data=input+"="+ dict[input];
            }            
            if(data!=""){
                Console.WriteLine(data);
            }
            else{
                Console.WriteLine("Not found");
            }

        }
        
    }
}

