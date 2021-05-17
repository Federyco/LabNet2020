import { Component, OnInit } from '@angular/core';
import {PokemonService} from '../services/pokemon.service';

@Component({
  selector: 'app-pokemon',
  templateUrl: './pokemon.component.html',
  styleUrls: ['./pokemon.component.scss']
})
export class PokemonComponent implements OnInit {
  name: string;
  constructor(private pokeService : PokemonService) { }

  ngOnInit(): void {
  }

  //esta funcion la ejecuta el html y le pasa el parametro el input
  search(){
    //console.log("entre al search");
    //console.log("me pasó el name: " + this.name);
    //utilizando mi servicio ingreso a la funcion que envía la url de la api
    //el camino que realiza la información es => input web ----> componente ----> servicio
    this.pokeService.pokeDex(this.name).subscribe(data =>{
      console.log(data)
    })
  }

}
