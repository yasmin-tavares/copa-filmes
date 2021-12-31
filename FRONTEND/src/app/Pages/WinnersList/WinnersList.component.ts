import { Component, OnInit, Input } from '@angular/core';

@Component({
  selector: 'app-WinnersList',
  templateUrl: './WinnersList.component.html',
  styleUrls: []
})
export class WinnersListComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  @Input() titulo = '';
  @Input() posicao = '';
}
