//14. 세개의 수중 가장 큰 수 찾아내기

int main(int argc, char** argv)
{
    int a, b, c; a = 5; b = 9; c = 4;
    printf("%d가 제일 큼!", a > b && a > c ? a : b > c ? b : c);
    return 0;
}