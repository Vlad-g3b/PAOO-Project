create table bunuri(
    bun_id number primary key,
    bun_nume varchar2(50),
    bun_id_proiect number,
    bun_impact_min number,
    bun_impact_max number,
    bun_domeniu_categ varchar2(50),
    bun_cost number,
    bun_cost_red number
    
);