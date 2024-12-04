#include <stdio.h>
#include <stdlib.h>

// Hàm chuyen so nguyên thành mang luu so nhi phân
void binary(int n, int *a, int leng) 
{
	int index = 0;
	
    // Duyet qua tung bit cua so nhi phan và luu vào mang
    for (int i = leng - 1; i >= 0; i--) 
	{
        int bit = (n >> i) & 1;
        a[index++] = bit;
    }
}

void quayX(int *X)
{
	int t = X[13] ^ X[16] ^ X[17] ^ X[18];
	for(int i = 18; i > 0; i--)
	{
		X[i] = X[i-1];
	}
	X[0] = t;
}

void quayY(int *Y)
{
    int t = Y[20] ^ Y[21];
    for (int i = 21; i > 0; i--) 
	{
        Y[i] = Y[i-1];
    }
    Y[0] = t;	
}

void quayZ(int *Z)
{
    int t = Z[7] ^ Z[20] ^ Z[21] ^ Z[22];
    for (int i = 22; i > 0; i--) 
	{
        Z[i] = Z[i-1];
    }
    Z[0] = t;	
}

// Hàm tìm maj (chiem da so)
int maj(int x, int y, int z) 
{
	int count1 = 0, count2 = 0;
	if(x == 0)	count1++;
	else count2++;
	if(y == 0) count1++;
	else count2++;
	if(z == 0) count1++;
	else count2++;
	if(count1 > count2)
		return 0;
	else
		return 1;
}


//Ham a5/1

void a5_1(FILE *inp, FILE *out)
{
	int X_val, Y_val, Z_val;
	int check = 0;
	check = fscanf(inp, "%d %d %d", &X_val, &Y_val, &Z_val);
	if(check != 3)
	{
		printf("Khong du du lieu de thuc hien. Vui long kiem tra lai!");
		return;
	}
	else{
		//Bien doi sang nhi phan
		int X[19], Y[22], Z[23];
		int s[4];
		
		binary(X_val, X, sizeof(X) / sizeof(X[0]));
		binary(Y_val, Y, sizeof(Y) / sizeof(Y[0]));
		binary(Z_val, Z, sizeof(Z) / sizeof(Z[0]));
		
		for(int i = 1; i <= 3; i++)
		{
			int x1 = X[1];
			int y3 = Y[3];
			int z3 = Z[3];
			
			int m = maj(x1,y3,z3);
			
			if(x1 == m){
				quayX(X);
			}
			if(y3 == m){
				quayY(Y);
			}
			if(z3 == m){
				quayZ(Z);
			}
			
			s[i] = X[18] ^ Y[21] ^ Z[22];
			
			fprintf(out, "%d ", s[i]);
		}
		printf("Ma hoa thanh cong!");
	}
	
	
}


int main(int argc, char *argv[]){
	if (argc != 3)
	{
	    printf("Cu phap chua dung.\n");
	    printf("Cu phap nhu sau: [Ten chuong trinh].exe [File_Input] [File_Output]");
	    return 1;
	}
	    
	char *inp_file = argv[1];
	char *out_file = argv[2];
		
	printf("--- THONG TIN ---\n");
	printf("File Input: %s\n", inp_file);
	printf("File Output: %s\n", out_file);
	printf("Dang xu ly...\n");
		
	FILE *p_input = fopen(inp_file, "r");
	FILE *p_output = fopen(out_file, "w");
	if (p_input == NULL)
	{
	    printf("File input khong ton tai\n");
	    return 0;
	}	
	else
	{
		a5_1(p_input, p_output);
	}
		
	printf("\n==========================\n");
	printf("|| Nguyen Khac Duy Hung ||\n");
	printf("||      63132095        ||\n");
	printf("==========================");
	
	fclose(p_input);
	fclose(p_output);
	return 1;    
}
