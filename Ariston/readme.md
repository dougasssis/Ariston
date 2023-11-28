# Desafio Ariston: Automatização Inteligente para uma Casa Conectada

O desafio proposto consiste na automatização de uma smart-home, com foco nos acumuladores da renomada marca Ariston. Esses dispositivos desempenham um papel fundamental no armazenamento e aquecimento de água, proporcionando uma fonte pronta para utilização nos sistemas de aquecimento de residências e edifícios comerciais. A Ariston é uma fabricante reconhecida por sua excelência na produção de aparelhos de aquecimento de água e sistemas de aquecimento, destacando-se pela eficiência energética, confiabilidade e facilidade de uso de seus produtos.

A marca incorpora tecnologias de ponta em seus acumuladores, visando otimizar o desempenho e a eficiência. Isso inclui isolamento térmico de alta qualidade, sistemas de controle inteligente e elementos de aquecimento de última geração.

Uma funcionalidade notável é a capacidade de alternância entre os modos "green" (altamente econômico) e "boost", que utiliza resistências tradicionais para aquecimento.

Essa flexibilidade permite aos usuários escolher entre uma abordagem mais econômica e eficiente em termos de energia (modo "green") e um aquecimento rápido e intensivo (modo "boost") quando a demanda por água quente é maior ou quando se busca um aquecimento mais rápido.

Contudo, o modelo padrão de fábrica muitas vezes não faz a melhor escolha entre os modos "green" e "boost", resultando em situações em que a casa fica sem água quente durante o dia, enquanto o acumulador permanece no modo "boost" durante a madrugada.

Através de engenharia reversa, conseguimos compreender a forma como o aplicativo mobile se comunica com o termoacumulador. Isso nos possibilita monitorar e manipular o dispositivo por meio de comandos.

Neste desafio, não será necessário desenvolver a comunicação entre o sistema e o termoacumulador. Os comandos serão representados pela interface IAristonNet com os comandos: Login (que retorna verdadeiro ou falso conforme o resultado), GetPlantData (para obter os dados atuais do termoacumulador) e SetMode (para alternar entre os modos "boost", "green" e "off").

## Funcionamento do Sistema

- O sistema irá monitorar continuamente o termoacumulador e ativar o modo "boost" sempre que a temperatura estiver abaixo de 40ºC entre as 6h e as 22h.
- Será possível consultar a temperatura atual por meio de um bot no Telegram, bem como enviar comandos para ativar imediatamente o modo "boost" entre 30ºC e 70ºC.
- Além disso, o sistema irá monitorar constantemente o termoacumulador e desativar o modo "boost" assim que a temperatura atingir 40ºC, a menos que um comando de sobrescrita de temperatura tenha sido enviado. 
