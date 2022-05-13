# Kucni-budzet
 Апликација за преглед финансијског стања и трансакција

Ентитети:

Јаки ентитети:
  1. Промет - садржи информације о трансакцији (id, datum, novcanik, osoba, trosak, kolicina, organizaciona jedinica, firma, ulaz, izlaz, opis) -- uraditi pozajmice (uzeo novac, sutra treba da vrati)
  2. Особа - подаци о особи (email, lozinka, ime, prezime, jmbg, uloga) -- stanje jedne osobe predstavlja zbir svih stanja u njenim novcanicima

Слаби ентитети (шифарници):
  3. Новчаник (id, naziv, stanje, osoba_email) - одакле узимамо новац
  4. Улога (id, naziv) - администратор или корисник
  5. Трошак (id, naziv) - на шта смо потрошили новац
  6. Организациона јединица (id, naziv) - где смо потрошили новац (Београд, Златибор, Копаоник,...)
  7. Фирма (id, naziv) - подаци о фирми