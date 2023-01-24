# ConsulaCEP
Projeto  de Estudo Criaçao de consulta de CEP com um bom Osasquence consulta de CEP das ruas de Osasco

**Fluxos (Jornadas) de consumo das API**
```mermaid
graph LR
A[User] -- Informar CEP --> B( Consulta o CEP na API Via CEP) --> Z(Carrega em um Lista de Memoria)
```
