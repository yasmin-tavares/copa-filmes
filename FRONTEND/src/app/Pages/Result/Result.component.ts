import { Component, OnInit } from '@angular/core';
import {Router} from '@angular/router';
import { FilmesVencedores } from '../../models/filmesVencedores';

@Component({
  selector: 'app-Result',
  templateUrl: './Result.component.html',
  styleUrls: ['./Result.component.css']
})
export class ResultComponent  {
  listaFilmes: any;
  filmesVencedores: FilmesVencedores[];

  constructor(private router: Router) {
    const nav = this.router.getCurrentNavigation();
    this.listaFilmes = nav.extras.state;
    }

    RedirectToDashboard(){
      this.router.navigateByUrl('/');
    }
}

