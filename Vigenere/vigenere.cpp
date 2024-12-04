#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void maHoa_Vigenere(FILE *inp, char key[], FILE *out) 
{
    char ch;
    int keyLen = strlen(key);
    int keyIndex = 0;

    while ((ch = fgetc(inp)) != EOF) 
	{
        if (ch >= 'a' && ch <= 'z') 
		{
            ch = ((ch - 'a' + key[keyIndex] - 'A') % 26) + 'A';
        } 
		else if (ch >= 'A' && ch <= 'Z') 
		{
            ch = ((ch - 'A' + key[keyIndex] - 'A') % 26) + 'A';
        }
        keyIndex = (keyIndex + 1) % keyLen;
        fputc(ch, out);
    }
}

void giaiMa_Vigenere(FILE *inp, char key[], FILE *out) 
{
    char ch;
    int keyLen = strlen(key);
    int keyIndex = 0;

    while ((ch = fgetc(inp)) != EOF) 
	{
        if (ch >= 'a' && ch <= 'z') 
		{
            ch = ((ch - 'a' - (key[keyIndex] - 'A') + 26) % 26) + 'a';
        } 
		else if (ch >= 'A' && ch <= 'Z') 
		{
            ch = ((ch - 'A' - (key[keyIndex] - 'A') + 26) % 26) + 'a';
        }
        keyIndex = (keyIndex + 1) % keyLen;
        fputc(ch, out);
    }
}

int main(int argc, char *argv[]) 
{

    if (argc != 5)
    {
        printf("Cu phap chua dung.\n");
        printf("Cu phap nhu sau: [Ten chuong trinh].exe [e/d] [Key] [File_Input] [File_Output]");
        return 1;
    }
    
    char *mode = argv[1];
	char *key = argv[2];
	char *inp_file = argv[3];
	char *out_file = argv[4];
	
	printf("--- THONG TIN ---\n");
	printf("Che do: ");
	if (*mode == 'e')
	{
	    printf("Ma hoa (Encrypt)\n");
	}
	else if (*mode == 'd')
	{
		printf("Giai ma (Decrypt)\n");
	}
	printf("Khoa: %s\n", key);
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
	    if (*mode == 'e')
	    {
	        maHoa_Vigenere(p_input, key, p_output);
	        printf("Ma hoa thanh cong.");
	    }
	    else if (*mode == 'd')
	    {
	        giaiMa_Vigenere(p_input, key, p_output);
	        printf("Giai ma thanh cong.");
	    }
	    else
	    {
	        printf("Lua chon khong hop le.");
	    }
	}
	
	printf("\n==========================\n");
	printf("|| Nguyen Khac Duy Hung ||\n");
	printf("||      63132095        ||\n");
	printf("==========================");
	
    fclose(p_input);
	fclose(p_output);
    return 1;    
}
