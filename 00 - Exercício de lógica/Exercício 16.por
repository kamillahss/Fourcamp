programa
{
	
	funcao inicio()
	{
		real altura, peso, imc
		escreva("Insira a sua altura:")
		leia(altura)
		escreva("Insira o seu peso:")
		leia(peso)
		imc = peso / (altura*altura)
		escreva("Seu imc é: ", imc)

		se(imc >= 18.5 e imc <= 25)
		{
			escreva("\nPeso normal!")
		}senao 
		{
			escreva("\nFim de teste")
		}
		
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 338; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */