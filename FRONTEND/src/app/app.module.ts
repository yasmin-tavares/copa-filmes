import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule } from '@angular/core';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';

import { MatCardModule} from '@angular/material/card';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatButtonModule } from '@angular/material/button';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';

import { ItensComponent } from './Pages/Itens/Itens.component';
import { MoviesListComponent } from './Pages/MoviesList/MoviesList.component';
import { WinnersListComponent } from './Pages/WinnersList/WinnersList.component';
import { ResultComponent } from './Pages/Result/Result.component';


@NgModule({
  declarations: [
    AppComponent,
    ItensComponent,
    MoviesListComponent,
    WinnersListComponent,
    ResultComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    MatCardModule,
    MatToolbarModule,
    MatButtonModule,
    MatCheckboxModule,

  ],
  schemas: [CUSTOM_ELEMENTS_SCHEMA],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
