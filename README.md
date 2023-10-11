# “Knife Hit” Clone

## Descrição do jogo Original:
- “Tap” na tela, ou clique pra arremessar a faca na vertical (unica interação do jogador)


- Alvo redondo e giratório deve receber todas as facas para passar de fase
- Ao passar de fase, fases ficam mais dificeis
    - Inicia com obstaculos
    - padrão de giro mais errático
    - mais facas para arremessar
    
- HUD
    - Munição a esquerda
    - Facas arremessadas no canto superior esquerdo
    - Maçãs acertadas no canto superior direito
    - Progresso de fase e BOSS em cima no meio
    
- Perde jogo ao acertar uma faca ao inves do alvo
- Ao perder, retorna para a primeira fase
- Ao derrotar um BOSS, ganha xp e facas novas


## Descrição dos scripts
A seguir, todos os scripts implementados
- Script do jogador
    - Ao receber input, impõe velocidade vertical em uma instância da faca
        - também ajusta o contador de facas
        
- Script da faca
    - Permanece com o alvo, girando de acordo
        - problemas com joints e colisões
        - resolvido mudando o “parent object” da faca
    - Arremessar múltiplas facas
        - resolvido instanciando facas novas com input
    - Ao colidir com outra faca, encerra o jogo
    - Determina quando passa de fase ao esgotar as facas
    - Efeitos sonoros ao acertar objetos diferentes


- Script do alvo:
    - Girar por uma quantidade aleatória de tempo, invertendo direções
        - resolvido com System.Random()
        - inverte aleatoriamente baseado em um dado de 100 lados
    - Iniciar com quantidade aleatória de facas/maçãs
        - problemas em encontrar a angulação/posição correta das facas (17:00+)
        - resolvido manualmente(19:15)


- Script da maçã
    - Objeto destrutível
    - Gira de acordo com o alvo que está preso
    - Pontuação no HUD


- Script do HUD
    - Pontuação conforme as facas permanecem no alvo
        - feito com script que controla o texto no HUD
    - Contador de alvos destruídos (contador de fases)
    - Pontuação de maçãs, conforme elas são destruídas
        - feito com detecção de colisões
    - Munição de facas conforme jogador as atira

    



