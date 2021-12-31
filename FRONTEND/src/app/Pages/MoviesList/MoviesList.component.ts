import { Component, OnInit } from '@angular/core';
import { FilmeService } from '../../Services/filme.service';
import { Filme } from 'src/app/Models/filme';
import {Router} from '@angular/router';

@Component({
  selector: 'app-MoviesList',
  templateUrl: './MoviesList.component.html',
  styleUrls: ['./MoviesList.component.css']
})
export class MoviesListComponent implements OnInit {

  listaFilmes: Filme[] = [];
  resultadoFinal: any = [];
  listaSelecionados: any = [];
  contador = 0;

  constructor(private servico: FilmeService, private router: Router) {
   }

  ngOnInit(){
    this.servico.listar()
    .subscribe((retornoApi)=> {
      this.listaFilmes = retornoApi;
    })
  }

  ObterItemSelecionado(eventoSelecionar, filme){
    //Verificando se no array já contém aquele filme
    console.log("VERIFICANDO CONTEÚDO DO ARRAY DE SELEÇÃO")
    console.log(this.listaSelecionados.includes(filme));


   if(eventoSelecionar.status = 'selected'){
     // quando pegar o evento, verificar se já existe no array
     if (!(this.listaSelecionados.includes(filme) == true)){
// se não, inserir (somar + 1)
        this.listaSelecionados.push(filme);
        console.log(this.listaSelecionados);
        this.contador ++;
        console.log(this.contador);
     } else {
       // se sim, remover  (somar - 1)
      this.listaSelecionados.pop(filme);
      console.log(this.listaSelecionados);
      this.contador --;
      console.log(this.contador);
     }

   }

  }

  EnviarFilmesSelecionados(){
    console.log("filmes", this.listaSelecionados);
    this.servico.enviar(this.listaSelecionados)
    .subscribe(( retornoApi => {
      this.resultadoFinal = retornoApi;
      this.RedirectToResultadoFinal(this.resultadoFinal);

      console.log(this.resultadoFinal);
    }),
      (erro) => {});

  }

  RedirectToResultadoFinal(resultado: any){
    this.router.navigateByUrl('/resultado', {state: resultado});

  }

}
