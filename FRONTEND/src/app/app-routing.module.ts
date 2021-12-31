import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { MoviesListComponent } from './Pages/MoviesList/MoviesList.component';
import { ResultComponent } from './Pages/Result/Result.component';


const routes: Routes = [
{path: '', component: MoviesListComponent},
{path: 'resultado', component: ResultComponent}

];

@NgModule({
  imports: [RouterModule.forRoot(routes)],

exports: [RouterModule]
})
export class AppRoutingModule { }
