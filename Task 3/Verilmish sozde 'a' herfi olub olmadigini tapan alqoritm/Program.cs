string word =  "qwerkgjfnvcKLWQFxalwijriAAWDB" ;
bool result=false;
for (int i = 0; i < word.Length; i++) {
    if (word[i] == 'a') { 
    result = true;
    break; }
}
if (result)
{
    Console.WriteLine("a herfi var");
}
else
{
    Console.WriteLine("a herfi yoxdur");    
}