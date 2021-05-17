import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class PokemonService {
  private url: string = "https://pokeapi.co/api/v2/pokemon/";

  //injeccion de dependencias
  constructor(private http:HttpClient) { }


  pokeDex(name: string){
    console.log("estoy en el pokedex " + name)
    console.log(this.url + name)
    return this.http.get(this.url + name);
  }
}
