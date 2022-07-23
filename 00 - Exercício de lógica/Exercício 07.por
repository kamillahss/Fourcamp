programa
{
	
	funcao inicio()
	{

 		 real umCent, cincoCent, dezCent, vinte_cincoCent, cinquentaCent, tot_cent, umReal, totReais

		escreva("quantidade de Moedas de 1 centavo: ")
		leia(umCent)

		escreva("quantidade de Moedas de 5 centavos: ")
		leia(cincoCent)

		cincoCent = (cincoCent*5)
		
		escreva("quantidade de Moedas de 10 centavo: ")
		leia(dezCent)
		dezCent = (dezCent*10)
		
		escreva("quantidade de Moedas de 25 centavo: ")
		leia(vinte_cincoCent)
		vinte_cincoCent = (vinte_cincoCent*25)

		escreva("quantidade de Moedas de 50 centavo: ")
		leia(cinquentaCent)
		cinquentaCent = (cinquentaCent*50)

		escreva("quantidade de Moedas de 1 real: ")
		leia(umReal)

		tot_cent = (umCent + cincoCent + dezCent + vinte_cincoCent + cinquentaCent)/100

		totReais = umReal + tot_cent

		escreva("O total de dinheiro poupado foi RS ", totReais)
	}
}
/* $$$ Portugol Studio $$$ 
 * 
 * Esta seção do arquivo guarda informações do Portugol Studio.
 * Você pode apagá-la se estiver utilizando outro editor.
 * 
 * @POSICAO-CURSOR = 300; 
 * @PONTOS-DE-PARADA = ;
 * @SIMBOLOS-INSPECIONADOS = ;
 * @FILTRO-ARVORE-TIPOS-DE-DADO = inteiro, real, logico, cadeia, caracter, vazio;
 * @FILTRO-ARVORE-TIPOS-DE-SIMBOLO = variavel, vetor, matriz, funcao;
 */