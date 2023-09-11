#include <stdio.h>

char* printInBinary(int num) {   
    if (num == 0) {
        return "0";
    }
   
   int binaryNum[32];
   int i=0;
   
   for ( ;num > 0; ){
      binaryNum[i++] = num % 2;
      num /= 2;
   }

  for (int j = i-1; j >= 0; j--)
      printf("%d", binaryNum[j]);
}

int main(void) {
  printInBinary(5);
  printf(" @ in spots\n");
  return 0;
}
