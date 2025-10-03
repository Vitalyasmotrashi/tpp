#include <cstdint>
#include <cmath>

#ifdef __cplusplus
extern "C" {
#endif

	__declspec(dllexport) float Sum(float* Array, int length) {
		// теперь считаем, что Array содержит два массива подряд: A и B
		int N = length / 2; // новая строка: половина длины — это размер одного массива
		float* A = Array;   // новая строка
		float* B = Array + N; // новая строка

		// складываем элементы: A = A + B
		for (int i = 0; i < N; ++i) // изменено
		{
			A[i] = A[i] + B[i]; // изменено
		}

		// пример для матрицы: если N — квадрат числа и кратен 4
		int n = (int)(sqrt((double)N)); // новая строка
		if (n * n == N && n % 4 == 0)   // новая строка
		{
			// интерпретируем A и B как матрицы n×n
			for (int r = 0; r < n; r++) // новая строка
				for (int c = 0; c < n; c++) // новая строка
				{
					int idx = r * n + c; // новая строка
					A[idx] = A[idx] + B[idx]; // новая строка
				}
		}

		return 0.0f; // изменено: возвращаем фиктивное значение (результат теперь в массиве A)
	}

	__declspec(dllexport) float SumXMM(float* Array, int length)
	{
		float result = 0;		
		float Res[4];
		int len = length * 4;
		float *p;
		p = Array;
		__asm
		{
			push ECX
			push EDI
			push ESI
			mov EDI, len
			mov ECX, 0 //xor ECX, ECX
			mov ESI, p
			pxor    xmm0, xmm0 //| 0 | 0 | 0 | 0 |
			Back :
				movups  xmm1, [ESI][ECX] //Array[ECX]
				addps   xmm0, xmm1
				add     ECX, 16
				cmp     ECX, EDI
			jne      Back
			movups Res, xmm0
			pop ESI
			pop EDI
			pop ECX
		}

		result = Res[0] + Res[1] + Res[2] + Res[3];
		return result;//len;
	}
#ifdef __cplusplus
}
#endif