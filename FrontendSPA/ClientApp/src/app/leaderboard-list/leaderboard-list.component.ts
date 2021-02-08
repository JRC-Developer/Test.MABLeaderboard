import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-leaderboard-list',
  templateUrl: './leaderboard-list.component.html'
})
export class LeaderboardListComponent {
  public records: leaderboardRecord[];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<leaderboardRecord[]>(baseUrl + 'leaderboard').subscribe(result => {
      this.records = result;
    }, error => console.error(error));
  }
}

interface leaderboardRecord {
  userID: number;
  score: string;
  gamesPlayed: string;
}

