#include <stdio.h>
#include <stdlib.h>

int N;
float number[];
void InputN() {
	//nhap so phan tu
	printf("Please enter N= \n");
	scanf("%d", &N);
	}
void InputNnumbers() {
	//nhap n phan tu
	int i;
	for (i=0; i< N; i++){
		printf("Input %d = \n", i);
		scanf("%f", &number[i]);}
}
void printarray() {
	//in cac phan tu trong mang
	int i;
	for (i=0; i<N; i++) {
		printf("number %d is: %f\n", i, number[i]);
		}
}
void reversNnumbers() {
	//dao nguoc day so
	int i;
	int index;
	int tmp;
	for(i=0; i< N/2; i++) {
        index = N - i - 1;
        tmp = number[index];
        number[index] = number[i];
        number[i] = tmp;
    }
}
void printfresult() {
	//xuat ket qua sau dao nguoc
	int i;
    for(i=0; i<N; i++){
        printf("%0.2f", number[i]);
    }
    printf("\n");
}
void deletenumberlocalk() {
	//xoa phan tu thu k
	int n;
	int i;
	int k;
	printf("Please enter the position to be rubbed k= \n");
	scanf("%d", &k);
	for(i=0;i< N; i++ ){
		number[k]=number[k+1];
		n=n-1;
		printf("%d",number[i]);
	}
}
void AscendingNnumbers() {
	int tg;
	int i;
	int j;
	for (i=0; i<N; i++) {
		for (j=0; j<N; j++) {
			if( number[i]>number[j]) {
			tg= number[i];
			number[i]=number[j];
			number[j]= tg;
			}
		}
	}
	printf("\nMang da sap xep la: ");
    for(i = 0; i < N; i++){
        printf("%5d", number[i]);
    }
}
/*
int main() {
	InputN();
	InputNnumbers();
	printarray();
	reversNnumbers();
	printfresult();
	deletenumberlocalk();
	AscendingNnumbers();	
}
*/
