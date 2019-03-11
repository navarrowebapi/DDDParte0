using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Tests.Entities
{
    [TestClass]
    public class StudentTest
    {

        [TestMethod]
        public void TestMethod1(){

            //Teste1 - criar a instância de um aluno - quais info eu preciso para ter um aluno?

            ////var student = new Student();

            //Resposta fácil: Só pegar as propriedades de aluno, mas será que preciso de um Endereço para criar um aluno?
            //Resposta melhor: Devemos definir nosso modelo/entidade um pouco mais rico para que ele expresse de fato o negócio
            //Ou seja, devemos criar um construtor para isso. Vamos até a classe Student e vamos criar este CTOR.
            
            var student = new Student("Fabio", "Navarro", "123123123", "navarro@univem.edu.br");

            //Já está melhor, mas ainda posso passar um sobrenome p. ex. VAZIO.
            //Isso em Entidades mais complexas como um Pagamento ou uma Sangria, ficaria mais dificil entender o que de fato é necessário para cada entidade

            //Limitamos ao construtor tendo um único ponto de entrada para esta classe, isto é muito bom.
            //Melhor ainda podemos setar determinadas propriedades como "private set" para não permitir este tipo de coisa.
            //isto se chama OPEN/CLOSED principle do SOLID.    

            //student.FirstName = "mudei"; //NAO PODERA FAZER ISSO

            //************TODO1 : Só podemos ter 1 assinatura ATIVA.
            // Criar uma regra de negócio para que todas as assinaturas antigas sejam desativadas e colocar esta nova como ATIVA
            
            //***CRIAR UM TESTE PARA ISSO.
        }

        [TestMethod]
        public void AdicionarAssinatura(){
            var subscription = new Subscription();
            var student = new Student("Fabio", "Navarro", "123123123", "navarro@univem.edu.br");
            
            //Como quebrar a regra de negócio
            //student.Subscriptions.Add(subscription);

            //Como consertar? usar IReadOnlyCollection na Subscriptions.
            student.AddSubscription(subscription);
        }
        
    }
}