import { Component, OnInit, Input, Output, EventEmitter } from '@angular/core';


@Component({
  selector: 'app-Itens',
  templateUrl: './Itens.component.html',
  styleUrls: ['./Itens.component.css']
})
export class ItensComponent {


  @Input() titulo = '';
  @Input() ano = '';
  @Input() nota = '';
  @Output('eventoSelecionar') itemSelecionadoEvento = new EventEmitter();
  situacao = true;
  selecionarFilme(selected: Event) {
    console.log('item selecionado');
    this.itemSelecionadoEvento.emit({status: 'selected'})
  }



}


